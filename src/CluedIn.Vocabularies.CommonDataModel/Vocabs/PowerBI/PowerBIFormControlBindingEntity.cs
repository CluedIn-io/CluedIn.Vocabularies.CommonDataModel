using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PowerBIFormControlBindingEntityVocabulary : SimpleVocabulary
    {
        public PowerBIFormControlBindingEntityVocabulary()
        {
            VocabularyName = "Power BI Form Control Binding Entity";
            KeyPrefix = "commonDataModel.powerbiformcontrolbindingentity";
            KeySeparator = ".";
            Grouping = "/PowerBIFormControlBindingEntity";

            AddGroup("PowerBIFormControlBindingEntity Details", group =>
            {
                FormName = group.Add(new VocabularyKey(nameof(FormName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DashboardId = group.Add(new VocabularyKey(nameof(DashboardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlId = group.Add(new VocabularyKey(nameof(ControlId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Size = group.Add(new VocabularyKey(nameof(Size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmbedUrl = group.Add(new VocabularyKey(nameof(EmbedUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormName { get; private set; }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey DashboardId { get; private set; }
        public VocabularyKey ControlId { get; private set; }
        public VocabularyKey Size { get; private set; }
        public VocabularyKey EmbedUrl { get; private set; }
    }
}