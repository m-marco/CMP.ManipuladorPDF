﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CMP.ManipuladorPDF
{

    public class SignatureException : Exception
    {
        public SignatureException(){}
        public SignatureException(string message) : base(message) {}
        public SignatureException(string message, Exception inner) : base(message, inner) {}
    }

    public class FontNotExistException : Exception
    {
        public FontNotExistException() { }
        public FontNotExistException(string message) : base(message) { }
        public FontNotExistException(string message, Exception inner) : base(message, inner) { }
    }

    public class HtmlConverterException : Exception
    {
        public HtmlConverterException() { }
        public HtmlConverterException(string message) : base(message) { }
        public HtmlConverterException(string message, Exception inner) : base(message, inner) { }
    }

    public class CertificateWrongPasswordException : Exception
    {
        public CertificateWrongPasswordException() { }
    }

    public class CertificateNotFoundException : Exception
    {
        public CertificateNotFoundException() { }
    }

    public class CertificateInvalidException : Exception
    {
        public CertificateInvalidException() { }
    }

    public class FontDirectoryEmptyException : Exception
    {
        public FontDirectoryEmptyException() { }
    }

    public class NotPDFADocumentException : Exception
    {
        public NotPDFADocumentException() { }
    }

    public class InvalidPDFDocumentException : Exception
    {
        public InvalidPDFDocumentException() { }
    }

}