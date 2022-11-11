using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CancelFiscalDocumentEntityVocabulary : SimpleVocabulary
    {
        public CancelFiscalDocumentEntityVocabulary()
        {
            VocabularyName = "Common Data Model CancelFiscalDocumentEntity";
            KeyPrefix = "commonDataModel.cancelfiscaldocumententity";
            KeySeparator = ".";
            Grouping = "/CancelFiscalDocumentEntity";

            AddGroup("Common Data Model CancelFiscalDocumentEntity Details", group =>
            {
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Series = group.Add(new VocabularyKey(nameof(Series), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentStatus = group.Add(new VocabularyKey(nameof(CurrentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(ThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CancelAccountingDate = group.Add(new VocabularyKey(nameof(CancelAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Direction { get; private set; }
        public VocabularyKey FiscalDocumentNumber { get; private set; }
        public VocabularyKey FiscalEstablishmentId { get; private set; }
        public VocabularyKey Series { get; private set; }
        public VocabularyKey CurrentStatus { get; private set; }
        public VocabularyKey ThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey CancelAccountingDate { get; private set; }


    }
}