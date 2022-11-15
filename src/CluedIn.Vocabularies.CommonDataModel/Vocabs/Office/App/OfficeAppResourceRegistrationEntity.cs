using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OfficeAppResourceRegistrationEntityVocabulary : SimpleVocabulary
    {
        public OfficeAppResourceRegistrationEntityVocabulary()
        {
            VocabularyName = "Office App Resource Registration Entity";
            KeyPrefix = "commonDataModel.officeappresourceregistrationentity";
            KeySeparator = ".";
            Grouping = "/OfficeAppResourceRegistrationEntity";

            AddGroup("OfficeAppResourceRegistrationEntity Details", group =>
            {
                ResourceID = group.Add(new VocabularyKey(nameof(ResourceID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelativeUrl = group.Add(new VocabularyKey(nameof(RelativeUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ResourceID { get; private set; }
        public VocabularyKey RelativeUrl { get; private set; }
    }
}