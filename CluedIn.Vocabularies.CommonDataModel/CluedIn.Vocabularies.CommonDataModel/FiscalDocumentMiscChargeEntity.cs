using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentMiscChargeEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentMiscChargeEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalDocumentMiscChargeEntity";
            KeyPrefix = "commonDataModel.fiscaldocumentmiscchargeentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentMiscChargeEntity";

            AddGroup("Common Data Model FiscalDocumentMiscChargeEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeNumber = group.Add(new VocabularyKey(nameof(ChargeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentDirection = group.Add(new VocabularyKey(nameof(FiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentLine = group.Add(new VocabularyKey(nameof(FiscalDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentLineNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentVoucher = group.Add(new VocabularyKey(nameof(FiscalDocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Amount { get; private set; }
public VocabularyKey ChargeNumber { get; private set; }
public VocabularyKey FiscalDocumentDirection { get; private set; }
public VocabularyKey FiscalDocumentFiscalEstablishmentId { get; private set; }
public VocabularyKey FiscalDocumentLine { get; private set; }
public VocabularyKey FiscalDocumentLineNumber { get; private set; }
public VocabularyKey FiscalDocumentNumber { get; private set; }
public VocabularyKey FiscalDocumentSeries { get; private set; }
public VocabularyKey FiscalDocumentStatus { get; private set; }
public VocabularyKey FiscalDocumentThirdPartyCNPJorCPF { get; private set; }
public VocabularyKey FiscalDocumentVoucher { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}