using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CompetitorSalesLiteratureVocabulary : SimpleVocabulary
    {
        public CompetitorSalesLiteratureVocabulary()
        {
            VocabularyName = "Competitor Sales Literature";
            KeyPrefix = "commonDataModel.competitorsalesliterature";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CompetitorSalesLiterature;

            AddGroup("CompetitorSalesLiterature Details for Sales", group =>
            {
                CompetitorSalesLiteratureId = group.Add(new VocabularyKey(nameof(CompetitorSalesLiteratureId), "Unique identifier of the sales literature for the competitor product.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CompetitorId"/> to Vocab 'Competitor.cdm.json/Competitor' with Property 'CompetitorId'
            ///Property <see cref="SalesLiteratureId"/> to Vocab 'SalesLiterature.cdm.json/SalesLiterature' with Property 'SalesLiteratureId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey CompetitorSalesLiteratureId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}