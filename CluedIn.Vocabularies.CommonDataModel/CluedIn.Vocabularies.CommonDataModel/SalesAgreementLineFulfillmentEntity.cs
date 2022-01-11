using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesAgreementLineFulfillmentEntityVocabulary : SimpleVocabulary
    {
        public SalesAgreementLineFulfillmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesAgreementLineFulfillmentEntity";
            KeyPrefix = "commonDataModel.salesagreementlinefulfillmententity";
            KeySeparator = ".";
            Grouping = "/SalesAgreementLineFulfillmentEntity";

            AddGroup("Common Data Model SalesAgreementLineFulfillmentEntity Details", group =>
            {
                SalesAgreementLegalEntityId = group.Add(new VocabularyKey(nameof(SalesAgreementLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesAgreementId = group.Add(new VocabularyKey(nameof(SalesAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommittedQuantity = group.Add(new VocabularyKey(nameof(CommittedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingQuantity = group.Add(new VocabularyKey(nameof(RemainingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReleasedQuantity = group.Add(new VocabularyKey(nameof(ReleasedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveredQuantity = group.Add(new VocabularyKey(nameof(DeliveredQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicedQuantity = group.Add(new VocabularyKey(nameof(InvoicedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommittedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(CommittedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RemainingCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReleasedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReleasedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveredCatchWeightQuantity = group.Add(new VocabularyKey(nameof(DeliveredCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(InvoicedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommittedAmount = group.Add(new VocabularyKey(nameof(CommittedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingAmount = group.Add(new VocabularyKey(nameof(RemainingAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReleasedAmount = group.Add(new VocabularyKey(nameof(ReleasedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveredAmount = group.Add(new VocabularyKey(nameof(DeliveredAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicedAmount = group.Add(new VocabularyKey(nameof(InvoicedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesAgreementLegalEntityId { get; private set; }
public VocabularyKey SalesAgreementId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey CommittedQuantity { get; private set; }
public VocabularyKey RemainingQuantity { get; private set; }
public VocabularyKey ReleasedQuantity { get; private set; }
public VocabularyKey DeliveredQuantity { get; private set; }
public VocabularyKey InvoicedQuantity { get; private set; }
public VocabularyKey UnitSymbol { get; private set; }
public VocabularyKey CommittedCatchWeightQuantity { get; private set; }
public VocabularyKey RemainingCatchWeightQuantity { get; private set; }
public VocabularyKey ReleasedCatchWeightQuantity { get; private set; }
public VocabularyKey DeliveredCatchWeightQuantity { get; private set; }
public VocabularyKey InvoicedCatchWeightQuantity { get; private set; }
public VocabularyKey CommittedAmount { get; private set; }
public VocabularyKey RemainingAmount { get; private set; }
public VocabularyKey ReleasedAmount { get; private set; }
public VocabularyKey DeliveredAmount { get; private set; }
public VocabularyKey InvoicedAmount { get; private set; }


    }
}