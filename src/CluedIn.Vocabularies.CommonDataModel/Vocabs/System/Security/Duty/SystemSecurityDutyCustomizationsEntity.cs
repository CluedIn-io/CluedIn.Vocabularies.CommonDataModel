using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityDutyCustomizationsEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityDutyCustomizationsEntityVocabulary()
        {
            VocabularyName = "System Security Duty Customizations Entity";
            KeyPrefix = "commonDataModel.systemsecuritydutycustomizationsentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityDutyCustomizationsEntity";

            AddGroup("SystemSecurityDutyCustomizationsEntity Details", group =>
            {
                Identifier = group.Add(new VocabularyKey(nameof(Identifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                XmlObject = group.Add(new VocabularyKey(nameof(XmlObject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey XmlObject { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
    }
}