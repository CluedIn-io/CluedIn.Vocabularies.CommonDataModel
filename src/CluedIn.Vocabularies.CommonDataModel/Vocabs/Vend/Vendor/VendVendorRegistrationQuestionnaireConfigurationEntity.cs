using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorRegistrationQuestionnaireConfigurationEntityVocabulary : SimpleVocabulary
    {
        public VendVendorRegistrationQuestionnaireConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendVendorRegistrationQuestionnaireConfigurationEntity";
            KeyPrefix = "commonDataModel.vendvendorregistrationquestionnaireconfigurationentity";
            KeySeparator = ".";
            Grouping = "/VendVendorRegistrationQuestionnaireConfigurationEntity";

            AddGroup("Common Data Model VendVendorRegistrationQuestionnaireConfigurationEntity Details", group =>
            {
                QuestionnaireDataAreaId = group.Add(new VocabularyKey(nameof(QuestionnaireDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuestionnaireId = group.Add(new VocabularyKey(nameof(QuestionnaireId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRegistrationConfigurationRecId = group.Add(new VocabularyKey(nameof(VendorRegistrationConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRegistrationConfigurationName = group.Add(new VocabularyKey(nameof(VendorRegistrationConfigurationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey QuestionnaireDataAreaId { get; private set; }
        public VocabularyKey QuestionnaireId { get; private set; }
        public VocabularyKey VendorRegistrationConfigurationRecId { get; private set; }
        public VocabularyKey VendorRegistrationConfigurationName { get; private set; }


    }
}