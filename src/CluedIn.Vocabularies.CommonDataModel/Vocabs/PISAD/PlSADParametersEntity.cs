using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADParametersEntityVocabulary : SimpleVocabulary
    {
        public PlSADParametersEntityVocabulary()
        {
            VocabularyName = "PlSADParametersEntity";
            KeyPrefix = "commonDataModel.plsadparametersentity";
            KeySeparator = ".";
            Grouping = "/PlSADParametersEntity";

            AddGroup("PlSADParametersEntity Details", group =>
            {
                InsuranceAccount = group.Add(new VocabularyKey(nameof(InsuranceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdditionalCostsFormInvoice = group.Add(new VocabularyKey(nameof(AdditionalCostsFormInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscPaymentsAccount = group.Add(new VocabularyKey(nameof(MiscPaymentsAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportAccount = group.Add(new VocabularyKey(nameof(TransportAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DutyRounding = group.Add(new VocabularyKey(nameof(DutyRounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseTaxRounding = group.Add(new VocabularyKey(nameof(ExciseTaxRounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscPayments = group.Add(new VocabularyKey(nameof(MiscPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscellaneousChargesFromTheSADDocumentAccount = group.Add(new VocabularyKey(nameof(MiscellaneousChargesFromTheSADDocumentAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportOnSADDocumentAccount = group.Add(new VocabularyKey(nameof(TransportOnSADDocumentAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATRounding = group.Add(new VocabularyKey(nameof(VATRounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuranceAccountDisplayValue = group.Add(new VocabularyKey(nameof(InsuranceAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscPaymentsAccountDisplayValue = group.Add(new VocabularyKey(nameof(MiscPaymentsAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportAccountDisplayValue = group.Add(new VocabularyKey(nameof(TransportAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscellaneousChargesFromTheSADDocumentAccountDisplayValue = group.Add(new VocabularyKey(nameof(MiscellaneousChargesFromTheSADDocumentAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportOnSADDocumentAccountDisplayValue = group.Add(new VocabularyKey(nameof(TransportOnSADDocumentAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InsuranceAccount { get; private set; }
        public VocabularyKey AdditionalCostsFormInvoice { get; private set; }
        public VocabularyKey MiscPaymentsAccount { get; private set; }
        public VocabularyKey TransportAccount { get; private set; }
        public VocabularyKey DutyRounding { get; private set; }
        public VocabularyKey ExciseTaxRounding { get; private set; }
        public VocabularyKey MiscPayments { get; private set; }
        public VocabularyKey MiscellaneousChargesFromTheSADDocumentAccount { get; private set; }
        public VocabularyKey TransportOnSADDocumentAccount { get; private set; }
        public VocabularyKey VATRounding { get; private set; }
        public VocabularyKey InsuranceAccountDisplayValue { get; private set; }
        public VocabularyKey MiscPaymentsAccountDisplayValue { get; private set; }
        public VocabularyKey TransportAccountDisplayValue { get; private set; }
        public VocabularyKey MiscellaneousChargesFromTheSADDocumentAccountDisplayValue { get; private set; }
        public VocabularyKey TransportOnSADDocumentAccountDisplayValue { get; private set; }


    }
}