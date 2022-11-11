using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommissionCalculationEntityVocabulary : SimpleVocabulary
    {
        public CommissionCalculationEntityVocabulary()
        {
            VocabularyName = "CommissionCalculationEntity";
            KeyPrefix = "commonDataModel.commissioncalculationentity";
            KeySeparator = ".";
            Grouping = "/CommissionCalculationEntity";

            AddGroup("CommissionCalculationEntity Details", group =>
            {
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionProductGroupId = group.Add(new VocabularyKey(nameof(CommissionProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerCode = group.Add(new VocabularyKey(nameof(CustomerCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRelation = group.Add(new VocabularyKey(nameof(CustomerRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionCustomerGroupId = group.Add(new VocabularyKey(nameof(CommissionCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesRepCode = group.Add(new VocabularyKey(nameof(SalesRepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionPercentage = group.Add(new VocabularyKey(nameof(CommissionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Basis = group.Add(new VocabularyKey(nameof(Basis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasisDiscountRule = group.Add(new VocabularyKey(nameof(BasisDiscountRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveFromDate = group.Add(new VocabularyKey(nameof(EffectiveFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveToDate = group.Add(new VocabularyKey(nameof(EffectiveToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSearchContinue = group.Add(new VocabularyKey(nameof(WillSearchContinue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpperThreshold_IT = group.Add(new VocabularyKey(nameof(UpperThreshold_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseThresholds_IT = group.Add(new VocabularyKey(nameof(UseThresholds_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowerThreshold_IT = group.Add(new VocabularyKey(nameof(LowerThreshold_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey CommissionProductGroupId { get; private set; }
        public VocabularyKey CustomerCode { get; private set; }
        public VocabularyKey CustomerRelation { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey CommissionCustomerGroupId { get; private set; }
        public VocabularyKey SalesRepCode { get; private set; }
        public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
        public VocabularyKey CommissionPercentage { get; private set; }
        public VocabularyKey Basis { get; private set; }
        public VocabularyKey BasisDiscountRule { get; private set; }
        public VocabularyKey EffectiveFromDate { get; private set; }
        public VocabularyKey EffectiveToDate { get; private set; }
        public VocabularyKey WillSearchContinue { get; private set; }
        public VocabularyKey RecordId { get; private set; }
        public VocabularyKey UpperThreshold_IT { get; private set; }
        public VocabularyKey UseThresholds_IT { get; private set; }
        public VocabularyKey LowerThreshold_IT { get; private set; }


    }
}