using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectDefaultOffsetAccountEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectDefaultOffsetAccountEntityVocabulary()
        {
            VocabularyName = "Proj Project Default Offset Account Entity";
            KeyPrefix = "commonDataModel.projprojectdefaultoffsetaccountentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectDefaultOffsetAccountEntity";

            AddGroup("ProjProjectDefaultOffsetAccountEntity Details", group =>
            {
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourcePersonnelNumber = group.Add(new VocabularyKey(nameof(ResourcePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey ResourcePersonnelNumber { get; private set; }
    }
}