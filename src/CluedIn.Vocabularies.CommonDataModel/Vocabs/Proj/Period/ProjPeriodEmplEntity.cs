using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjPeriodEmplEntityVocabulary : SimpleVocabulary
    {
        public ProjPeriodEmplEntityVocabulary()
        {
            VocabularyName = "Proj Period Empl Entity";
            KeyPrefix = "commonDataModel.projperiodemplentity";
            KeySeparator = ".";
            Grouping = "/ProjPeriodEmplEntity";

            AddGroup("ProjPeriodEmplEntity Details", group =>
            {
                NormBillable = group.Add(new VocabularyKey(nameof(NormBillable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NormEfficiency = group.Add(new VocabularyKey(nameof(NormEfficiency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodFrom = group.Add(new VocabularyKey(nameof(PeriodFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey NormBillable { get; private set; }
        public VocabularyKey NormEfficiency { get; private set; }
        public VocabularyKey PeriodFrom { get; private set; }
        public VocabularyKey PeriodId { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
    }
}