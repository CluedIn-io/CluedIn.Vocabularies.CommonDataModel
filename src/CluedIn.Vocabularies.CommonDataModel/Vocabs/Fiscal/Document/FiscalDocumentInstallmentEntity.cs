using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentInstallmentEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentInstallmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalDocumentInstallmentEntity";
            KeyPrefix = "commonDataModel.fiscaldocumentinstallmententity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentInstallmentEntity";

            AddGroup("Common Data Model FiscalDocumentInstallmentEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocument = group.Add(new VocabularyKey(nameof(FiscalDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentCustVendTrans = group.Add(new VocabularyKey(nameof(FiscalDocumentCustVendTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentDirection = group.Add(new VocabularyKey(nameof(FiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentVoucher = group.Add(new VocabularyKey(nameof(FiscalDocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InstallmentNumber = group.Add(new VocabularyKey(nameof(InstallmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Amount { get; private set; }
public VocabularyKey DueDate { get; private set; }
public VocabularyKey FiscalDocument { get; private set; }
public VocabularyKey FiscalDocumentCustVendTrans { get; private set; }
public VocabularyKey FiscalDocumentDirection { get; private set; }
public VocabularyKey FiscalDocumentFiscalEstablishmentId { get; private set; }
public VocabularyKey FiscalDocumentNumber { get; private set; }
public VocabularyKey FiscalDocumentSeries { get; private set; }
public VocabularyKey FiscalDocumentStatus { get; private set; }
public VocabularyKey FiscalDocumentThirdPartyCNPJorCPF { get; private set; }
public VocabularyKey FiscalDocumentVoucher { get; private set; }
public VocabularyKey InstallmentNumber { get; private set; }


    }
}