using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExceptionCodeEntityVocabulary : SimpleVocabulary
    {
        public ExceptionCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ExceptionCodeEntity";
            KeyPrefix = "commonDataModel.exceptioncodeentity";
            KeySeparator = ".";
            Grouping = "/ExceptionCodeEntity";

            AddGroup("Common Data Model ExceptionCodeEntity Details", group =>
            {
                ApproximateTaxRateForImportedProducts = group.Add(new VocabularyKey(nameof(ApproximateTaxRateForImportedProducts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproximateTaxRateForNationalProducts = group.Add(new VocabularyKey(nameof(ApproximateTaxRateForNationalProducts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExceptionCode = group.Add(new VocabularyKey(nameof(ExceptionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalClassificationId = group.Add(new VocabularyKey(nameof(FiscalClassificationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalClassificationCode = group.Add(new VocabularyKey(nameof(FiscalClassificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApproximateTaxRateForImportedProducts { get; private set; }
        public VocabularyKey ApproximateTaxRateForNationalProducts { get; private set; }
        public VocabularyKey ExceptionCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FiscalClassificationId { get; private set; }
        public VocabularyKey FiscalClassificationCode { get; private set; }


    }
}