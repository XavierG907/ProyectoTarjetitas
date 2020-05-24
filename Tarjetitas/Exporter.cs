using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace Tarjetitas
{
    class Exporter
    {
        TarjetitasDB db = new TarjetitasDB();
        DataTable cards = new DataTable();
        int _IdBaraja;
		string _DeckName;
		string _Author;
		public Exporter(int idBataja, string deckName, string author)
		{
			_IdBaraja = idBataja;
			_DeckName = deckName;
			_Author = author;
		}
		public int IdBaraja
		{
			get { return _IdBaraja; }
			set { _IdBaraja = value; }
		}
		public string DeckName
		{
			get { return _DeckName; }
			set { _DeckName = value; }
		}
		public string Author
		{
			get { return _Author; }
			set { _Author = value; }
		}
		public void ExportToPDF()
        {
			//Buscar tarjetas
			GetAllCards();
			// Hacer formato reciclable

			//Agregar tarjetas
			AddCards();
            //Elegir nombre de archivo y ubicacion

            //Guardar pdf
        }
        private void GetAllCards()
        {
            string query = "SELECT * FROM tarjetas WHERE idBaraja=" + IdBaraja.ToString() + " AND elimLogica=0;";
            cards = db.consulta(query);
        }
        private void MakeFileFormat()
        {

        }
		void AddCards()
		{
			Document doc = new Document(PageSize.LETTER);
			// Indicamos donde vamos a guardar el documento
			SaveFileDialog source = new SaveFileDialog();
			source.Filter = "PDF documents|*.pdf";
			source.FileName = DeckName;
			DialogResult r = source.ShowDialog();
			if (source.FileName == "" || r == DialogResult.Cancel)
				return;
			PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@source.FileName, FileMode.Create));
			doc.SetMargins(84,84,70,70);
			writer.PageEvent = new HeaderFooter("Autor: "+Author,"Tarjetitas Pro - QuickSoft");
			// Le colocamos el título y el autor
			// **Nota: Esto no será visible en el documento
			doc.AddTitle("TarjetitasPro");
			doc.AddCreator("QuickSoft");

			doc.Open();
			//family, float size, int style, Color color;
			FontFamily family = new FontFamily("Arial");
			iTextSharp.text.Font f = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
			iTextSharp.text.Font f2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,
									 12, iTextSharp.text.Font.BOLD, BaseColor.RED);
			iTextSharp.text.Font f3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,
									 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

			PdfPTable inicio = new PdfPTable(1);
			inicio.WidthPercentage = 100f;
			inicio.DefaultCell.Border = 0;
			PdfPCell _cell = new PdfPCell(new Paragraph(DeckName, f2));
			_cell.HorizontalAlignment = Element.ALIGN_CENTER;
			_cell.Border = 0;
			inicio.AddCell(_cell);
			inicio.AddCell(new Paragraph(Chunk.NEWLINE));
			inicio.AddCell(new Paragraph("Total de tarjetas: "+cards.Rows.Count.ToString(), f3));
			doc.Add(inicio);
			doc.Add(new Paragraph(Chunk.NEWLINE));

			for (int i = 0; i < cards.Rows.Count; i++)
			{
				PdfPTable tabla = TCard(i);
				doc.Add(tabla);
				doc.Add(Chunk.NEWLINE);
			}

			doc.Close();
			writer.Close();
			Process.Start(@source.FileName);
		}

		public PdfPTable TCard(int it)
		{
			iTextSharp.text.Font f = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,
									 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
			iTextSharp.text.Font fTitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,
									 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
			iTextSharp.text.Font fError = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,
									 12, iTextSharp.text.Font.ITALIC, BaseColor.BLACK);

			//Crear tabla
			PdfPTable tabla_carta = new PdfPTable(1);
			tabla_carta.WidthPercentage = 100f;
			PdfPCell celda;
			string temp;

			celda = new PdfPCell(new Phrase("FRENTE:", fTitle));
			celda.BorderWidthBottom = 0;
			celda.BackgroundColor = new BaseColor(Color.AliceBlue);
			tabla_carta.AddCell(celda);
			//
			temp = cards.Rows[it]["frente"].ToString();
			celda = new PdfPCell(new Phrase(temp, f));
			celda.BorderWidthTop = celda.BorderWidthBottom = 0;
			celda.BackgroundColor = new BaseColor(Color.AliceBlue);
			celda.HorizontalAlignment = Element.ALIGN_CENTER;
			tabla_carta.AddCell(celda);
			//salto de linea
			celda = new PdfPCell(new Phrase(" "));//salto de linea
			celda.BorderWidthTop = 0;
			celda.BackgroundColor = new BaseColor(Color.AliceBlue);
			tabla_carta.AddCell(celda);

			celda = new PdfPCell(new Phrase("REVERSO:", fTitle));
			celda.BorderWidthBottom = 0;
			celda.BackgroundColor = new BaseColor(Color.LightGreen);
			tabla_carta.AddCell(celda);
			//
			if (cards.Rows[it]["tipoDeTarjeta"].ToString() == "TEXT")
			{
				temp = cards.Rows[it]["reverso"].ToString();
				celda = new PdfPCell(new Phrase(temp, f));
			}
			else if (cards.Rows[it]["tipoDeTarjeta"].ToString() == "TEXT-IMAGE")
			{
				iTextSharp.text.Image img;
				if (File.Exists(@cards.Rows[it]["reverso"].ToString()))
				{
					img = iTextSharp.text.Image.GetInstance(@cards.Rows[it]["reverso"].ToString());
					celda = new PdfPCell(img);
				}
				else
				{
					img = iTextSharp.text.Image.GetInstance(Properties.Resources.Error,new BaseColor(Color.LightGreen));
					img.ScaleAbsolute(100f,100f);
					celda = new PdfPCell(img,false);
					celda.BorderWidthBottom = celda.BorderWidthTop = 0;
					celda.BackgroundColor = new BaseColor(Color.LightGreen);
					celda.HorizontalAlignment = Element.ALIGN_CENTER;
					tabla_carta.AddCell(celda);

					temp = "Lo sentimos. No se pudo encontrar la imagen!!";
					celda = new PdfPCell(new Paragraph(temp, fError));
				}
			}
			else
			{
				iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Error, new BaseColor(Color.LightGreen));
				img.ScaleAbsolute(100f, 100f);
				celda = new PdfPCell(img, false);
				celda.BorderWidthBottom = celda.BorderWidthTop = 0;
				celda.BackgroundColor = new BaseColor(Color.LightGreen);
				celda.HorizontalAlignment = Element.ALIGN_CENTER;
				tabla_carta.AddCell(celda);

				temp = "Lo sentimos. No se puede mostrar el contenido de este archivo multimedia!!";
				celda = new PdfPCell(new Phrase(temp, fError));
			}
			celda.BorderWidthTop = celda.BorderWidthBottom =  0;
			celda.BackgroundColor = new BaseColor(Color.LightGreen);
			celda.HorizontalAlignment = Element.ALIGN_CENTER;
			tabla_carta.AddCell(celda);

			celda = new PdfPCell(new Phrase(" "));//salto de linea
			celda.BorderWidthTop = 0;
			celda.BackgroundColor = new BaseColor(Color.LightGreen);
			tabla_carta.AddCell(celda);
			return tabla_carta;
		}
	}

	// Para poder poner encabezado y pie de pagina, necesito de utilizar pageevents
	class HeaderFooter : PdfPageEventHelper
	{
		string _header;
		string _footer;
		public HeaderFooter(string header, string footer)
		{
			_header = header;
			_footer = footer;
		}
		public override void OnEndPage(PdfWriter writer, Document document)
		{
			//base.OnEndPage(writer, document);
			iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,
									 12, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);

			PdfPTable header = new PdfPTable(2); //Izquierda, centro, derecha
			header.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin; //ancho
			header.DefaultCell.Border = 0;

			PdfPCell _cell = new PdfPCell(new Paragraph(_header, fuente));
			_cell.HorizontalAlignment = Element.ALIGN_LEFT;
			_cell.Border = 0;
			header.AddCell(_cell);
			//
			_cell = new PdfPCell(new Paragraph(DateTime.Now.ToString("dd-MM-yyyy"),fuente));
			_cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			_cell.Border = 0;
			header.AddCell(_cell);

			header.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin)+40, writer.DirectContent);

			PdfPTable footer = new PdfPTable(3); //Izquierda, centro, derecha
			footer.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin; //ancho
			footer.DefaultCell.Border = 0;

			//
			_cell = new PdfPCell(new Paragraph(_footer, fuente));
			_cell.HorizontalAlignment = Element.ALIGN_LEFT;
			_cell.Border = 0;
			footer.AddCell(_cell);
			//
			_cell = new PdfPCell(new Paragraph(""+writer.PageNumber, fuente));
			_cell.HorizontalAlignment = Element.ALIGN_CENTER;
			_cell.Border = 0;
			footer.AddCell(_cell);
			//
			footer.AddCell(new Paragraph());

			footer.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin)-30, writer.DirectContent);

			//Agregar bordes (margen)
			/*var content = writer.DirectContent;
			var pageBorderRect = new iTextSharp.text.Rectangle(document.PageSize);

			pageBorderRect.Left += document.LeftMargin-30;
			pageBorderRect.Right -= document.RightMargin-30;
			pageBorderRect.Top -= document.TopMargin-20;
			pageBorderRect.Bottom += document.BottomMargin-20;

			content.SetColorStroke(BaseColor.BLACK);
			content.Rectangle(pageBorderRect.Left, pageBorderRect.Bottom, pageBorderRect.Width, pageBorderRect.Height);
			
			content.Stroke();
			*/
		}
	}
}
