using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CaseAssociationEntityVocabulary : SimpleVocabulary
    {
        public CaseAssociationEntityVocabulary()
        {
            VocabularyName = "Common Data Model CaseAssociationEntity";
            KeyPrefix = "commonDataModel.caseassociationentity";
            KeySeparator = ".";
            Grouping = "/CaseAssociationEntity";

            AddGroup("Common Data Model CaseAssociationEntity Details", group =>
            {
                AssociationCompany = group.Add(new VocabularyKey(nameof(AssociationCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationId = group.Add(new VocabularyKey(nameof(AssociationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CaseId = group.Add(new VocabularyKey(nameof(CaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CaseRecId = group.Add(new VocabularyKey(nameof(CaseRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityType = group.Add(new VocabularyKey(nameof(EntityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssociationCompany { get; private set; }
        public VocabularyKey AssociationId { get; private set; }
        public VocabularyKey CaseId { get; private set; }
        public VocabularyKey CaseRecId { get; private set; }
        public VocabularyKey EntityType { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey Reference { get; private set; }


    }
}