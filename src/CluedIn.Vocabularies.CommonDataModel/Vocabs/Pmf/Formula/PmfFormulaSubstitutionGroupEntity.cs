using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PmfFormulaSubstitutionGroupEntityVocabulary : SimpleVocabulary
    {
        public PmfFormulaSubstitutionGroupEntityVocabulary()
        {
            VocabularyName = "Pmf Formula Substitution Group Entity";
            KeyPrefix = "commonDataModel.pmfformulasubstitutiongroupentity";
            KeySeparator = ".";
            Grouping = "/PmfFormulaSubstitutionGroupEntity";

            AddGroup("PmfFormulaSubstitutionGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}