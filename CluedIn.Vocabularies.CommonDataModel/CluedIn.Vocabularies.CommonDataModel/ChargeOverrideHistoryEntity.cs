using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ChargeOverrideHistoryEntityVocabulary : SimpleVocabulary
    {
        public ChargeOverrideHistoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model ChargeOverrideHistoryEntity";
            KeyPrefix = "commonDataModel.chargeoverridehistoryentity";
            KeySeparator = ".";
            Grouping = "/ChargeOverrideHistoryEntity";

            AddGroup("Common Data Model ChargeOverrideHistoryEntity Details", group =>
            {
                ChargeCode = group.Add(new VocabularyKey(nameof(ChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalAmount = group.Add(new VocabularyKey(nameof(OriginalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverrideAmount = group.Add(new VocabularyKey(nameof(OverrideAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverrideReason = group.Add(new VocabularyKey(nameof(OverrideReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderId = group.Add(new VocabularyKey(nameof(SalesOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverrideTime = group.Add(new VocabularyKey(nameof(OverrideTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Store = group.Add(new VocabularyKey(nameof(Store), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AxUserId = group.Add(new VocabularyKey(nameof(AxUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarkupTransRecId = group.Add(new VocabularyKey(nameof(MarkupTransRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalValue = group.Add(new VocabularyKey(nameof(OriginalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverriddenFieldNumber = group.Add(new VocabularyKey(nameof(OverriddenFieldNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverriddenValue = group.Add(new VocabularyKey(nameof(OverriddenValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ChargeCode { get; private set; }
public VocabularyKey OriginalAmount { get; private set; }
public VocabularyKey OverrideAmount { get; private set; }
public VocabularyKey OverrideReason { get; private set; }
public VocabularyKey SalesOrderId { get; private set; }
public VocabularyKey TransactionId { get; private set; }
public VocabularyKey UserId { get; private set; }
public VocabularyKey OverrideTime { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey Store { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey AxUserId { get; private set; }
public VocabularyKey MarkupTransRecId { get; private set; }
public VocabularyKey OriginalValue { get; private set; }
public VocabularyKey OverriddenFieldNumber { get; private set; }
public VocabularyKey OverriddenValue { get; private set; }


    }
}