using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomRegistrationFieldVocabulary : SimpleVocabulary
    {
        public CustomRegistrationFieldVocabulary()
        {
            VocabularyName = "CustomRegistrationField";
            KeyPrefix = "commonDataModel.customregistrationfield";
            KeySeparator = ".";
            Grouping = "/CustomRegistrationField";

            AddGroup("CustomRegistrationField Details", group =>
            {
                choices = group.Add(new VocabularyKey(nameof(choices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                customRegistrationFieldId = group.Add(new VocabularyKey(nameof(customRegistrationFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isRequired = group.Add(new VocabularyKey(nameof(isRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                text = group.Add(new VocabularyKey(nameof(text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey choices { get; private set; }
        public VocabularyKey customRegistrationFieldId { get; private set; }
        public VocabularyKey isRequired { get; private set; }
        public VocabularyKey text { get; private set; }
        public VocabularyKey type { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}