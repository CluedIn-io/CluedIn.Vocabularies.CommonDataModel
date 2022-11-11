using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PowerBIFormControlBindingEntityVocabulary : SimpleVocabulary
    {
        public PowerBIFormControlBindingEntityVocabulary()
        {
            VocabularyName = "PowerBIFormControlBindingEntity";
            KeyPrefix = "commonDataModel.powerbiformcontrolbindingentity";
            KeySeparator = ".";
            Grouping = "/PowerBIFormControlBindingEntity";

            AddGroup("PowerBIFormControlBindingEntity Details", group =>
            {
                formName = group.Add(new VocabularyKey(nameof(formName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                userId = group.Add(new VocabularyKey(nameof(userId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                dashboardId = group.Add(new VocabularyKey(nameof(dashboardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                controlId = group.Add(new VocabularyKey(nameof(controlId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                size = group.Add(new VocabularyKey(nameof(size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                embedUrl = group.Add(new VocabularyKey(nameof(embedUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey formName { get; private set; }
        public VocabularyKey userId { get; private set; }
        public VocabularyKey dashboardId { get; private set; }
        public VocabularyKey controlId { get; private set; }
        public VocabularyKey size { get; private set; }
        public VocabularyKey embedUrl { get; private set; }


    }
}