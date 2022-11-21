using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocTechResponsibleInformationEntityVocabulary : SimpleVocabulary
    {
        public EFDocTechResponsibleInformationEntityVocabulary()
        {
            VocabularyName = "EF Doc Tech Responsible Information Entity";
            KeyPrefix = "commonDataModel.efdoctechresponsibleinformationentity";
            KeySeparator = ".";
            Grouping = "/EFDocTechResponsibleInformationEntity";

            AddGroup("EFDocTechResponsibleInformationEntity Details", group =>
            {
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalResponsibleCNPJ = group.Add(new VocabularyKey(nameof(TechnicalResponsibleCNPJ), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalResponsibleContactName = group.Add(new VocabularyKey(nameof(TechnicalResponsibleContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalResponsibleEmail = group.Add(new VocabularyKey(nameof(TechnicalResponsibleEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalResponsiblePhone = group.Add(new VocabularyKey(nameof(TechnicalResponsiblePhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalResponsibleCSRTId = group.Add(new VocabularyKey(nameof(TechnicalResponsibleCSRTId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalResponsibleCSRT = group.Add(new VocabularyKey(nameof(TechnicalResponsibleCSRT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey State { get; private set; }
        public VocabularyKey TechnicalResponsibleCNPJ { get; private set; }
        public VocabularyKey TechnicalResponsibleContactName { get; private set; }
        public VocabularyKey TechnicalResponsibleEmail { get; private set; }
        public VocabularyKey TechnicalResponsiblePhone { get; private set; }
        public VocabularyKey TechnicalResponsibleCSRTId { get; private set; }
        public VocabularyKey TechnicalResponsibleCSRT { get; private set; }
    }
}