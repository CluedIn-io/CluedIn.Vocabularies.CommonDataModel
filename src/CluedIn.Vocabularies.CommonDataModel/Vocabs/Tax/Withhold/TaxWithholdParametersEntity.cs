using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdParametersEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdParametersEntity";
            KeyPrefix = "commonDataModel.taxwithholdparametersentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdParametersEntity";

            AddGroup("Common Data Model TaxWithholdParametersEntity Details", group =>
            {
                CrossCompanyPayment = group.Add(new VocabularyKey(nameof(CrossCompanyPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableWarningMsg = group.Add(new VocabularyKey(nameof(EnableWarningMsg), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSActivate = group.Add(new VocabularyKey(nameof(TCSActivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSInvoice = group.Add(new VocabularyKey(nameof(TCSInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSPayment = group.Add(new VocabularyKey(nameof(TCSPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSActivate = group.Add(new VocabularyKey(nameof(TDSActivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSInvoice = group.Add(new VocabularyKey(nameof(TDSInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSPayment = group.Add(new VocabularyKey(nameof(TDSPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CrossCompanyPayment { get; private set; }
        public VocabularyKey EnableWarningMsg { get; private set; }
        public VocabularyKey TCSActivate { get; private set; }
        public VocabularyKey TCSInvoice { get; private set; }
        public VocabularyKey TCSPayment { get; private set; }
        public VocabularyKey TDSActivate { get; private set; }
        public VocabularyKey TDSInvoice { get; private set; }
        public VocabularyKey TDSPayment { get; private set; }
        public VocabularyKey Key { get; private set; }


    }
}