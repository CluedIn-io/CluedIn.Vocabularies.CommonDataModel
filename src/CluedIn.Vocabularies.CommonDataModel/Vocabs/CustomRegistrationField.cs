using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomRegistrationFieldVocabulary : SimpleVocabulary
    {
        public CustomRegistrationFieldVocabulary()
        {
            VocabularyName = "Custom Registration Field";
            KeyPrefix = "commonDataModel.customregistrationfield";
            KeySeparator = ".";
            Grouping = "/CustomRegistrationField";

            AddGroup("CustomRegistrationField Details", group =>
            {
                Choices = group.Add(new VocabularyKey(nameof(Choices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomRegistrationFieldId = group.Add(new VocabularyKey(nameof(CustomRegistrationFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRequired = group.Add(new VocabularyKey(nameof(IsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Choices { get; private set; }
        public VocabularyKey CustomRegistrationFieldId { get; private set; }
        public VocabularyKey IsRequired { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}