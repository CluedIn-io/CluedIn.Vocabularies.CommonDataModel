using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25RegisterTableEntityVocabulary : SimpleVocabulary
    {
        public RTax25RegisterTableEntityVocabulary()
        {
            VocabularyName = "RTax25RegisterTableEntity";
            KeyPrefix = "commonDataModel.rtax25registertableentity";
            KeySeparator = ".";
            Grouping = "/RTax25RegisterTableEntity";

            AddGroup("RTax25RegisterTableEntity Details", group =>
            {
                Exclude = group.Add(new VocabularyKey(nameof(Exclude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTypes = group.Add(new VocabularyKey(nameof(PeriodTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterCode = group.Add(new VocabularyKey(nameof(RegisterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterName = group.Add(new VocabularyKey(nameof(RegisterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterType = group.Add(new VocabularyKey(nameof(RegisterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Expand = group.Add(new VocabularyKey(nameof(Expand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Exclude { get; private set; }
        public VocabularyKey PeriodTypes { get; private set; }
        public VocabularyKey RegisterCode { get; private set; }
        public VocabularyKey RegisterName { get; private set; }
        public VocabularyKey RegisterType { get; private set; }
        public VocabularyKey Expand { get; private set; }


    }
}