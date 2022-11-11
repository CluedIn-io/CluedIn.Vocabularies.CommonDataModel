using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRSourceCodeEntityVocabulary : SimpleVocabulary
    {
        public MCRSourceCodeEntityVocabulary()
        {
            VocabularyName = "MCRSourceCodeEntity";
            KeyPrefix = "commonDataModel.mcrsourcecodeentity";
            KeySeparator = ".";
            Grouping = "/MCRSourceCodeEntity";

            AddGroup("MCRSourceCodeEntity Details", group =>
            {
                ActualCost = group.Add(new VocabularyKey(nameof(ActualCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistributionQuantity = group.Add(new VocabularyKey(nameof(DistributionQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FutureOrderDate = group.Add(new VocabularyKey(nameof(FutureOrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailDate = group.Add(new VocabularyKey(nameof(MailDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailingCosts = group.Add(new VocabularyKey(nameof(MailingCosts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnlyCatalogPlans = group.Add(new VocabularyKey(nameof(OnlyCatalogPlans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherCost = group.Add(new VocabularyKey(nameof(OtherCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintingCosts = group.Add(new VocabularyKey(nameof(PrintingCosts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedFirstOrderDate = group.Add(new VocabularyKey(nameof(ProjectedFirstOrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedOrders = group.Add(new VocabularyKey(nameof(ProjectedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedReturns = group.Add(new VocabularyKey(nameof(ProjectedReturns), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedSales = group.Add(new VocabularyKey(nameof(ProjectedSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceId = group.Add(new VocabularyKey(nameof(SourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetId = group.Add(new VocabularyKey(nameof(TargetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActualCost { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DistributionQuantity { get; private set; }
        public VocabularyKey FutureOrderDate { get; private set; }
        public VocabularyKey MailDate { get; private set; }
        public VocabularyKey MailingCosts { get; private set; }
        public VocabularyKey OnlyCatalogPlans { get; private set; }
        public VocabularyKey OtherCost { get; private set; }
        public VocabularyKey PrintingCosts { get; private set; }
        public VocabularyKey ProjectedFirstOrderDate { get; private set; }
        public VocabularyKey ProjectedOrders { get; private set; }
        public VocabularyKey ProjectedReturns { get; private set; }
        public VocabularyKey ProjectedSales { get; private set; }
        public VocabularyKey SourceId { get; private set; }
        public VocabularyKey TargetId { get; private set; }
        public VocabularyKey CatalogNumber { get; private set; }


    }
}