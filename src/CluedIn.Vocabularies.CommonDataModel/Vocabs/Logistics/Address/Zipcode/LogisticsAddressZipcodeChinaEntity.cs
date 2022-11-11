using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressZipcodeChinaEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressZipcodeChinaEntityVocabulary()
        {
            VocabularyName = "LogisticsAddressZipcodeChinaEntity";
            KeyPrefix = "commonDataModel.logisticsaddresszipcodechinaentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressZipcodeChinaEntity";

            AddGroup("LogisticsAddressZipcodeChinaEntity Details", group =>
            {
                yzbm = group.Add(new VocabularyKey(nameof(yzbm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                xzqh = group.Add(new VocabularyKey(nameof(xzqh), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                xzqu = group.Add(new VocabularyKey(nameof(xzqu), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                jd1 = group.Add(new VocabularyKey(nameof(jd1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                jd2 = group.Add(new VocabularyKey(nameof(jd2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                jd3 = group.Add(new VocabularyKey(nameof(jd3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                jd4 = group.Add(new VocabularyKey(nameof(jd4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                jd5 = group.Add(new VocabularyKey(nameof(jd5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey yzbm { get; private set; }
        public VocabularyKey xzqh { get; private set; }
        public VocabularyKey xzqu { get; private set; }
        public VocabularyKey jd1 { get; private set; }
        public VocabularyKey jd2 { get; private set; }
        public VocabularyKey jd3 { get; private set; }
        public VocabularyKey jd4 { get; private set; }
        public VocabularyKey jd5 { get; private set; }
        public VocabularyKey Country { get; private set; }


    }
}