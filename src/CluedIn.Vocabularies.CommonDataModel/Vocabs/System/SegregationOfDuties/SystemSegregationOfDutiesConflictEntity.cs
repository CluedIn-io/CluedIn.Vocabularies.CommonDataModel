using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSegregationOfDutiesConflictEntityVocabulary : SimpleVocabulary
    {
        public SystemSegregationOfDutiesConflictEntityVocabulary()
        {
            VocabularyName = "SystemSegregationOfDutiesConflictEntity";
            KeyPrefix = "commonDataModel.systemsegregationofdutiesconflictentity";
            KeySeparator = ".";
            Grouping = "/SystemSegregationOfDutiesConflictEntity";

            AddGroup("SystemSegregationOfDutiesConflictEntity Details", group =>
            {
                SegregationOfDutiesRule = group.Add(new VocabularyKey(nameof(SegregationOfDutiesRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegregationOfDutiesRuleValidFrom = group.Add(new VocabularyKey(nameof(SegregationOfDutiesRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegregationOfDutiesRuleValidTo = group.Add(new VocabularyKey(nameof(SegregationOfDutiesRuleValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegregationOfDutiesRuleName = group.Add(new VocabularyKey(nameof(SegregationOfDutiesRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                User = group.Add(new VocabularyKey(nameof(User), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExistingRole = group.Add(new VocabularyKey(nameof(ExistingRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExistingRoleIdentifier = group.Add(new VocabularyKey(nameof(ExistingRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExistingRoleName = group.Add(new VocabularyKey(nameof(ExistingRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExistingDuty = group.Add(new VocabularyKey(nameof(ExistingDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExistingDutyIdentifier = group.Add(new VocabularyKey(nameof(ExistingDutyIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExistingDutyName = group.Add(new VocabularyKey(nameof(ExistingDutyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewRole = group.Add(new VocabularyKey(nameof(NewRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewRoleIdentifier = group.Add(new VocabularyKey(nameof(NewRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewRoleName = group.Add(new VocabularyKey(nameof(NewRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewDuty = group.Add(new VocabularyKey(nameof(NewDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewDutyIdentifier = group.Add(new VocabularyKey(nameof(NewDutyIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewDutyName = group.Add(new VocabularyKey(nameof(NewDutyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignmentMode = group.Add(new VocabularyKey(nameof(AssignmentMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonForOverride = group.Add(new VocabularyKey(nameof(ReasonForOverride), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resolution = group.Add(new VocabularyKey(nameof(Resolution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SegregationOfDutiesRule { get; private set; }
        public VocabularyKey SegregationOfDutiesRuleValidFrom { get; private set; }
        public VocabularyKey SegregationOfDutiesRuleValidTo { get; private set; }
        public VocabularyKey SegregationOfDutiesRuleName { get; private set; }
        public VocabularyKey User { get; private set; }
        public VocabularyKey ExistingRole { get; private set; }
        public VocabularyKey ExistingRoleIdentifier { get; private set; }
        public VocabularyKey ExistingRoleName { get; private set; }
        public VocabularyKey ExistingDuty { get; private set; }
        public VocabularyKey ExistingDutyIdentifier { get; private set; }
        public VocabularyKey ExistingDutyName { get; private set; }
        public VocabularyKey NewRole { get; private set; }
        public VocabularyKey NewRoleIdentifier { get; private set; }
        public VocabularyKey NewRoleName { get; private set; }
        public VocabularyKey NewDuty { get; private set; }
        public VocabularyKey NewDutyIdentifier { get; private set; }
        public VocabularyKey NewDutyName { get; private set; }
        public VocabularyKey AssignmentMode { get; private set; }
        public VocabularyKey ReasonForOverride { get; private set; }
        public VocabularyKey Resolution { get; private set; }


    }
}