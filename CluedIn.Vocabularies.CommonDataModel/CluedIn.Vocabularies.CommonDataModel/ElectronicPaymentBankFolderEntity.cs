using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentBankFolderEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentBankFolderEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicPaymentBankFolderEntity";
            KeyPrefix = "commonDataModel.electronicpaymentbankfolderentity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentBankFolderEntity";

            AddGroup("Common Data Model ElectronicPaymentBankFolderEntity Details", group =>
            {
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankFolder = group.Add(new VocabularyKey(nameof(BankFolder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankFolderCode = group.Add(new VocabularyKey(nameof(BankFolderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LayoutGroupId { get; private set; }
public VocabularyKey BankFolder { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey BankFolderCode { get; private set; }


    }
}