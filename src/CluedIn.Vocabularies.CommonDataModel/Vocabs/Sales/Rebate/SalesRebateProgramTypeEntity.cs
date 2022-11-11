using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateProgramTypeEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateProgramTypeEntityVocabulary()
        {
            VocabularyName = "SalesRebateProgramTypeEntity";
            KeyPrefix = "commonDataModel.salesrebateprogramtypeentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateProgramTypeEntity";

            AddGroup("SalesRebateProgramTypeEntity Details", group =>
            {
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateProgramType = group.Add(new VocabularyKey(nameof(RebateProgramType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultAccuralMainAccountId = group.Add(new VocabularyKey(nameof(DefaultAccuralMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultExpenseMainAccountId = group.Add(new VocabularyKey(nameof(DefaultExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultAccuralMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(DefaultAccuralMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(DefaultExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey RebateProgramType { get; private set; }
        public VocabularyKey DefaultAccuralMainAccountId { get; private set; }
        public VocabularyKey DefaultExpenseMainAccountId { get; private set; }
        public VocabularyKey DefaultAccuralMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey DefaultExpenseMainAccountIdDisplayValue { get; private set; }


    }
}