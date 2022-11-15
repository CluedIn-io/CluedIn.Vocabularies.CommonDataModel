using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressZipcodeChinaEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressZipcodeChinaEntityVocabulary()
        {
            VocabularyName = "Logistics Address Zipcode China Entity";
            KeyPrefix = "commonDataModel.logisticsaddresszipcodechinaentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressZipcodeChinaEntity";

            AddGroup("LogisticsAddressZipcodeChinaEntity Details", group =>
            {
                Yzbm = group.Add(new VocabularyKey(nameof(Yzbm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Xzqh = group.Add(new VocabularyKey(nameof(Xzqh), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Xzqu = group.Add(new VocabularyKey(nameof(Xzqu), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Jd1 = group.Add(new VocabularyKey(nameof(Jd1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Jd2 = group.Add(new VocabularyKey(nameof(Jd2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Jd3 = group.Add(new VocabularyKey(nameof(Jd3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Jd4 = group.Add(new VocabularyKey(nameof(Jd4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Jd5 = group.Add(new VocabularyKey(nameof(Jd5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Yzbm { get; private set; }
        public VocabularyKey Xzqh { get; private set; }
        public VocabularyKey Xzqu { get; private set; }
        public VocabularyKey Jd1 { get; private set; }
        public VocabularyKey Jd2 { get; private set; }
        public VocabularyKey Jd3 { get; private set; }
        public VocabularyKey Jd4 { get; private set; }
        public VocabularyKey Jd5 { get; private set; }
        public VocabularyKey Country { get; private set; }
    }
}