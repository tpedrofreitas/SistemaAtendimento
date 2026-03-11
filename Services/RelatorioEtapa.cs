using QuestPDF.Fluent;

using QuestPDF.Helpers;

using QuestPDF.Infrastructure;

using QuestPDF.Companion;

using SistemaAtendimento.Model;

namespace SistemaAtendimento.Services

{

    internal class RelatorioEtapa

    {

        //  public class Relatoriousuario

        //{

        public string GerarListaEtapas(List<Etapas> listaEtapas)

        {

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            string caminho = Path.Combine(Path.GetTempPath(), $"RelatorioEtapas_{Guid.NewGuid()}.pdf");

            Document.Create(container => {

                container.Page(page => {

                    page.Size(PageSizes.A4);

                    page.Margin(1, Unit.Centimetre);

                    page.PageColor(Colors.White);

                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Verdana));


                    //Inicio Cabeçalho

                    page.Header().BorderBottom(1).PaddingBottom(5).Row(row => {

                        row.RelativeItem(1).Column(col => {

                            string logoPath = Path.Combine(AppContext.BaseDirectory, "Assets", "logotiposenac.png");

                            if (File.Exists(logoPath))

                            {

                                col.Item().Width(80).Image(logoPath);

                            }

                            else

                            {

                                col.Item().Text("SENAC").FontSize(14).Bold();

                            }


                        });

                        row.RelativeItem(1).AlignCenter().AlignMiddle().Text("Lista de Etapas").FontSize(16).Bold();

                        row.RelativeItem(1).AlignRight().AlignMiddle().Text(t => {

                            t.Span("Data: ").Bold();

                            t.Span(DateTime.Now.ToString("dd/MM/yyyy"));

                        });

                    });


                    //Conteúdo Central
                    page.Content().PaddingVertical(10).Table(table =>
                    {

                        table.ColumnsDefinition(columns =>
                        {

                            columns.ConstantColumn(30); // ID
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(3);
                            columns.RelativeColumn(2);

                        });

                        table.Header(header =>
                        {

                            header.Cell().BorderBottom(1).Text("ID").Bold();
                            header.Cell().BorderBottom(1).Text("NOME").Bold();
                            header.Cell().BorderBottom(1).Text("ORDEM").Bold();
                            header.Cell().BorderBottom(1).Text("ATIVO").Bold();

                        });
                        foreach (var etapa in listaEtapas)
                        {
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(etapa.Id.ToString());
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(etapa.Nome ?? "-");
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(etapa.Ordem ?? "-");
                            table.Cell().BorderBottom(0.5f).PaddingVertical(2).Text(etapa.Ativo.ToString());
                           
                        }
                    });
                   

                    page.Footer().AlignCenter().Text(t => {

                        t.Span("Página ");

                        t.CurrentPageNumber();

                    });

                });


            }).GeneratePdf(caminho);

            return caminho;

        }

        

    }

}

