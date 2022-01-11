using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdConcessionEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdConcessionEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdConcessionEntity";
            KeyPrefix = "commonDataModel.taxwithholdconcessionentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdConcessionEntity";

            AddGroup("Common Data Model TaxWithholdConcessionEntity Details", group =>
            {
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Remark = group.Add(new VocabularyKey(nameof(Remark), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SectionCode = group.Add(new VocabularyKey(nameof(SectionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxCode = group.Add(new VocabularyKey(nameof(WithholdingTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Certificate = group.Add(new VocabularyKey(nameof(Certificate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CertificateFromDate = group.Add(new VocabularyKey(nameof(CertificateFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CertificateToDate = group.Add(new VocabularyKey(nameof(CertificateToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendAccount = group.Add(new VocabularyKey(nameof(VendAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HeaderId = group.Add(new VocabularyKey(nameof(HeaderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineID = group.Add(new VocabularyKey(nameof(LineID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FromDate { get; private set; }
public VocabularyKey Remark { get; private set; }
public VocabularyKey SectionCode { get; private set; }
public VocabularyKey TaxType { get; private set; }
public VocabularyKey WithholdingTaxCode { get; private set; }
public VocabularyKey ToDate { get; private set; }
public VocabularyKey Certificate { get; private set; }
public VocabularyKey CertificateFromDate { get; private set; }
public VocabularyKey CertificateToDate { get; private set; }
public VocabularyKey VendAccount { get; private set; }
public VocabularyKey CustAccount { get; private set; }
public VocabularyKey HeaderId { get; private set; }
public VocabularyKey LineID { get; private set; }


    }
}