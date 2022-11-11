using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSegregationOfDutiesRuleEntityVocabulary : SimpleVocabulary
    {
        public SystemSegregationOfDutiesRuleEntityVocabulary()
        {
            VocabularyName = "SystemSegregationOfDutiesRuleEntity";
            KeyPrefix = "commonDataModel.systemsegregationofdutiesruleentity";
            KeySeparator = ".";
            Grouping = "/SystemSegregationOfDutiesRuleEntity";

            AddGroup("SystemSegregationOfDutiesRuleEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstDuty = group.Add(new VocabularyKey(nameof(FirstDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondDuty = group.Add(new VocabularyKey(nameof(SecondDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstSecurityDutyIdentifier = group.Add(new VocabularyKey(nameof(FirstSecurityDutyIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstSecurityDutyName = group.Add(new VocabularyKey(nameof(FirstSecurityDutyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondSecurityDutyIdentifier = group.Add(new VocabularyKey(nameof(SecondSecurityDutyIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondSecurityDutyName = group.Add(new VocabularyKey(nameof(SecondSecurityDutyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Severity = group.Add(new VocabularyKey(nameof(Severity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Risk = group.Add(new VocabularyKey(nameof(Risk), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mitigation = group.Add(new VocabularyKey(nameof(Mitigation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey FirstDuty { get; private set; }
        public VocabularyKey SecondDuty { get; private set; }
        public VocabularyKey FirstSecurityDutyIdentifier { get; private set; }
        public VocabularyKey FirstSecurityDutyName { get; private set; }
        public VocabularyKey SecondSecurityDutyIdentifier { get; private set; }
        public VocabularyKey SecondSecurityDutyName { get; private set; }
        public VocabularyKey Severity { get; private set; }
        public VocabularyKey Risk { get; private set; }
        public VocabularyKey Mitigation { get; private set; }


    }
}