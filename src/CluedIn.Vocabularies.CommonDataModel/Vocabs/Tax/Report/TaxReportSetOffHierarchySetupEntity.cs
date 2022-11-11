using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReportSetOffHierarchySetupEntityVocabulary : SimpleVocabulary
    {
        public TaxReportSetOffHierarchySetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxReportSetOffHierarchySetupEntity";
            KeyPrefix = "commonDataModel.taxreportsetoffhierarchysetupentity";
            KeySeparator = ".";
            Grouping = "/TaxReportSetOffHierarchySetupEntity";

            AddGroup("Common Data Model TaxReportSetOffHierarchySetupEntity Details", group =>
            {
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyVersion = group.Add(new VocabularyKey(nameof(HierarchyVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey HierarchyVersion { get; private set; }
        public VocabularyKey HierarchyName { get; private set; }


    }
}