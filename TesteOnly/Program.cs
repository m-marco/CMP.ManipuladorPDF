﻿using CMP.ManipuladorPDF;

string path = "C:\\arquivos\\";
string output = "final.pdf";
string certificate = "C:\\arquivos\\certificados\\fabio.pfx";
string password = "1234ab";

Adobe.Acrobat.FecharAcrobat();

DocumentoPDF documento = new DocumentoPDF($"{path}sample.pdf");

documento
    .AdicionarMetadado("Name", "Value")
    .Juntar("C:\\testepdf\\tese.pdf")
    .Numerar()
    .AdicionarMetadado(new Metadado("Nome 4", "Valor 4"))
    .Protocolar("99/2024", DateTime.Now, "X0X0X0X0")
    .TornarSemEfeito()
    .Assinar(certificate, password,1, 20, 770)
    .AdicionarDetalhesAoFinal("JAHSOMWE")
    .Salvar($"{path}{output}");

Adobe.Acrobat.AbrirAcrobat($"{path}{output}");