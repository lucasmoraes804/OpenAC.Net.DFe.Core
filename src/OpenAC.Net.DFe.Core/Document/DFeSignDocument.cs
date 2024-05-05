using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Common;

namespace OpenAC.Net.DFe.Core.Document;

public abstract class DFeSignDocument<TDocument> : DFeDocument<TDocument> where TDocument : class
{
    #region Properties

    [DFeElement("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = int.MaxValue)]
    public DFeSignature Signature { get; set; }

    #endregion Properties

    #region Methods

    /// <summary>
    /// Assina o xml.
    /// </summary>
    /// <param name="certificado">The certificado.</param>
    /// <param name="comments">if set to <c>true</c> [comments].</param>
    /// <param name="digest">The digest.</param>
    /// <param name="options">The options.</param>
    /// <param name="canonicalizationMethod">The canonicalizationMethod.</param>
    protected void AssinarDocumento(X509Certificate2 certificado, DFeSaveOptions options, bool comments, SignDigest digest, string canonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl)
    {
        Signature = XmlSigning.AssinarDocumento(this, certificado, comments, digest, options, out var xml, canonicalizationMethod);
        Xml = xml;
    }

    /// <summary>
    /// Valida a assinatura do documento.
    /// </summary>
    /// <param name="gerarXml"></param>
    /// <returns></returns>
    protected bool ValidarAssinaturaDocumento(bool gerarXml)
    {
        return XmlSigning.ValidarAssinatura(this, gerarXml);
    }

    /// <summary>
    /// Metodo que define se deve ou não serialziar a assinatura.
    /// </summary>
    /// <returns></returns>
    protected virtual bool ShouldSerializeSignature()
    {
        return !Signature.SignatureValue.IsEmpty() &&
               !Signature.SignedInfo.Reference.DigestValue.IsEmpty() &&
               !Signature.KeyInfo.X509Data.X509Certificate.IsEmpty();
    }

    #endregion Methods
}