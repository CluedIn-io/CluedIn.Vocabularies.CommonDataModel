using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRCatalogRequestEntityVocabulary : SimpleVocabulary
    {
        public MCRCatalogRequestEntityVocabulary()
        {
            VocabularyName = "MCR Catalog Request Entity";
            KeyPrefix = "commonDataModel.mcrcatalogrequestentity";
            KeySeparator = ".";
            Grouping = "/MCRCatalogRequestEntity";

            AddGroup("MCRCatalogRequestEntity Details", group =>
            {
                CatalogDescription = group.Add(new VocabularyKey(nameof(CatalogDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogId = group.Add(new VocabularyKey(nameof(LogId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestStatus = group.Add(new VocabularyKey(nameof(RequestStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessRelationAccount = group.Add(new VocabularyKey(nameof(BusinessRelationAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogRequestNumber = group.Add(new VocabularyKey(nameof(CatalogRequestNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CatalogDescription { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey LogId { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
        public VocabularyKey RequestStatus { get; private set; }
        public VocabularyKey BusinessRelationAccount { get; private set; }
        public VocabularyKey CatalogRequestNumber { get; private set; }
    }
}