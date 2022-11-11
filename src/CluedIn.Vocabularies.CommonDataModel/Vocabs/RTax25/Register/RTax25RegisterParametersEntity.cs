using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25RegisterParametersEntityVocabulary : SimpleVocabulary
    {
        public RTax25RegisterParametersEntityVocabulary()
        {
            VocabularyName = "RTax25RegisterParametersEntity";
            KeyPrefix = "commonDataModel.rtax25registerparametersentity";
            KeySeparator = ".";
            Grouping = "/RTax25RegisterParametersEntity";

            AddGroup("RTax25RegisterParametersEntity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParameterCode = group.Add(new VocabularyKey(nameof(ParameterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParameterName = group.Add(new VocabularyKey(nameof(ParameterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterCode = group.Add(new VocabularyKey(nameof(RegisterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey ParameterCode { get; private set; }
        public VocabularyKey ParameterName { get; private set; }
        public VocabularyKey RegisterCode { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }


    }
}