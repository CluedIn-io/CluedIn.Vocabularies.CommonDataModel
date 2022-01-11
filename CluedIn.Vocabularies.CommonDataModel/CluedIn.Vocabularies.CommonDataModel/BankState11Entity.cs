using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankState11EntityVocabulary : SimpleVocabulary
    {
        public BankState11EntityVocabulary()
        {
            VocabularyName = "Common Data Model BankState11Entity";
            KeyPrefix = "commonDataModel.bankstate11entity";
            KeySeparator = ".";
            Grouping = "/BankState11Entity";

            AddGroup("Common Data Model BankState11Entity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportOnState11 = group.Add(new VocabularyKey(nameof(ReportOnState11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BankAccount { get; private set; }
public VocabularyKey SequenceNumber { get; private set; }
public VocabularyKey ReportOnState11 { get; private set; }


    }
}