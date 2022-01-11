using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmplAdvLineEntityVocabulary : SimpleVocabulary
    {
        public EmplAdvLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model EmplAdvLineEntity";
            KeyPrefix = "commonDataModel.empladvlineentity";
            KeySeparator = ".";
            Grouping = "/EmplAdvLineEntity";

            AddGroup("Common Data Model EmplAdvLineEntity Details", group =>
            {
                AdvanceId = group.Add(new VocabularyKey(nameof(AdvanceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmedAmountOfAdvanceReport = group.Add(new VocabularyKey(nameof(ConfirmedAmountOfAdvanceReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisbursementDate = group.Add(new VocabularyKey(nameof(DisbursementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentName = group.Add(new VocabularyKey(nameof(DocumentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverRate = group.Add(new VocabularyKey(nameof(OverRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AdvanceId { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey ConfirmedAmountOfAdvanceReport { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey DisbursementDate { get; private set; }
public VocabularyKey DocumentName { get; private set; }
public VocabularyKey DocumentNumber { get; private set; }
public VocabularyKey OverRate { get; private set; }
public VocabularyKey MainAccount { get; private set; }
public VocabularyKey LineNum { get; private set; }


    }
}