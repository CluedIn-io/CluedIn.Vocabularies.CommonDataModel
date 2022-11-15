using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesContactPersonTitleEntityVocabulary : SimpleVocabulary
    {
        public SalesContactPersonTitleEntityVocabulary()
        {
            VocabularyName = "Sales Contact Person Title Entity";
            KeyPrefix = "commonDataModel.salescontactpersontitleentity";
            KeySeparator = ".";
            Grouping = "/SalesContactPersonTitleEntity";

            AddGroup("SalesContactPersonTitleEntity Details", group =>
            {
                JobTitle = group.Add(new VocabularyKey(nameof(JobTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTitleAlias = group.Add(new VocabularyKey(nameof(JobTitleAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey JobTitleAlias { get; private set; }
    }
}