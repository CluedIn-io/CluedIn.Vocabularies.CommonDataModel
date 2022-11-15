using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseDelegateEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseDelegateEntityVocabulary()
        {
            VocabularyName = "Trv Expense Delegate Entity";
            KeyPrefix = "commonDataModel.trvexpensedelegateentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseDelegateEntity";

            AddGroup("TrvExpenseDelegateEntity Details", group =>
            {
                DelegatedUser = group.Add(new VocabularyKey(nameof(DelegatedUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelegatedWorker = group.Add(new VocabularyKey(nameof(DelegatedWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelegatingWorker = group.Add(new VocabularyKey(nameof(DelegatingWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDateUTC = group.Add(new VocabularyKey(nameof(FromDateUTC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDateUTC = group.Add(new VocabularyKey(nameof(ToDateUTC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelegatedPersonnelNumber = group.Add(new VocabularyKey(nameof(DelegatedPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelegatingPersonnelNumber = group.Add(new VocabularyKey(nameof(DelegatingPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DelegatedUser { get; private set; }
        public VocabularyKey DelegatedWorker { get; private set; }
        public VocabularyKey DelegatingWorker { get; private set; }
        public VocabularyKey FromDateUTC { get; private set; }
        public VocabularyKey ToDateUTC { get; private set; }
        public VocabularyKey DelegatedPersonnelNumber { get; private set; }
        public VocabularyKey DelegatingPersonnelNumber { get; private set; }
    }
}