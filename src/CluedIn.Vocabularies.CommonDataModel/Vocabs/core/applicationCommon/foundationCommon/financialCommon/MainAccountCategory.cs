using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FinancialCommon
{
    public class MainAccountCategoryVocabulary : SimpleVocabulary
    {
        public MainAccountCategoryVocabulary()
        {
            VocabularyName = "Main Account Category";
            KeyPrefix = "commonDataModel.mainaccountcategory.financialcommon";
            KeySeparator = ".";
            Grouping = "/MainAccountCategory";

            AddGroup("MainAccountCategory Details for FinancialCommon", group =>
            {
			    MainAccountCategoryId = group.Add(new VocabularyKey(nameof(MainAccountCategoryId), "Main Account Category ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsClosed = group.Add(new VocabularyKey(nameof(IsClosed), "Is Closed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MainAccountCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsClosed { get; private set; }
        public VocabularyKey AccountType { get; private set; }
    }
}