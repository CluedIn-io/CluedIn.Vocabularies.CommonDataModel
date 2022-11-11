using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BOMBillOfMaterialsHeaderEntityVocabulary : SimpleVocabulary
    {
        public BOMBillOfMaterialsHeaderEntityVocabulary()
        {
            VocabularyName = "BOMBillOfMaterialsHeaderEntity";
            KeyPrefix = "commonDataModel.bombillofmaterialsheaderentity";
            KeySeparator = ".";
            Grouping = "/BOMBillOfMaterialsHeaderEntity";

            AddGroup("BOMBillOfMaterialsHeaderEntity Details", group =>
            {
                IsApproved = group.Add(new VocabularyKey(nameof(IsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverId = group.Add(new VocabularyKey(nameof(ApproverId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMName = group.Add(new VocabularyKey(nameof(BOMName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngChgProductItemRecId = group.Add(new VocabularyKey(nameof(EngChgProductItemRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngChgEngineeringBomReference = group.Add(new VocabularyKey(nameof(EngChgEngineeringBomReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsApproved { get; private set; }
        public VocabularyKey ApproverId { get; private set; }
        public VocabularyKey BOMId { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey BOMName { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }
        public VocabularyKey EngChgProductItemRecId { get; private set; }
        public VocabularyKey EngChgEngineeringBomReference { get; private set; }


    }
}