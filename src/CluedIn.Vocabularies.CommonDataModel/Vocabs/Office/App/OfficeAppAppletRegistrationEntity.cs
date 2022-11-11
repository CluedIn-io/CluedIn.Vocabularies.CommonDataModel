using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OfficeAppAppletRegistrationEntityVocabulary : SimpleVocabulary
    {
        public OfficeAppAppletRegistrationEntityVocabulary()
        {
            VocabularyName = "Common Data Model OfficeAppAppletRegistrationEntity";
            KeyPrefix = "commonDataModel.officeappappletregistrationentity";
            KeySeparator = ".";
            Grouping = "/OfficeAppAppletRegistrationEntity";

            AddGroup("Common Data Model OfficeAppAppletRegistrationEntity Details", group =>
            {
                AppletID = group.Add(new VocabularyKey(nameof(AppletID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelativeUrl = group.Add(new VocabularyKey(nameof(RelativeUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredAppVersion = group.Add(new VocabularyKey(nameof(RequiredAppVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SupportedApplications = group.Add(new VocabularyKey(nameof(SupportedApplications), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DependentOn = group.Add(new VocabularyKey(nameof(DependentOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AppletID { get; private set; }
        public VocabularyKey RelativeUrl { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RequiredAppVersion { get; private set; }
        public VocabularyKey SupportedApplications { get; private set; }
        public VocabularyKey DependentOn { get; private set; }


    }
}