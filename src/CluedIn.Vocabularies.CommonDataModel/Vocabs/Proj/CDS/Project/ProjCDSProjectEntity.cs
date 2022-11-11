using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSProjectEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSProjectEntityVocabulary()
        {
            VocabularyName = "ProjCDSProjectEntity";
            KeyPrefix = "commonDataModel.projcdsprojectentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSProjectEntity";

            AddGroup("ProjCDSProjectEntity Details", group =>
            {
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectName = group.Add(new VocabularyKey(nameof(ProjectName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectGroup = group.Add(new VocabularyKey(nameof(ProjectGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectType = group.Add(new VocabularyKey(nameof(ProjectType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectStatus = group.Add(new VocabularyKey(nameof(ProjectStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedStartDate = group.Add(new VocabularyKey(nameof(ProjectedStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedEndDate = group.Add(new VocabularyKey(nameof(ProjectedEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentId = group.Add(new VocabularyKey(nameof(ParentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectManagerPersonnelNumber = group.Add(new VocabularyKey(nameof(ProjectManagerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDataID = group.Add(new VocabularyKey(nameof(SourceDataID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey ProjectName { get; private set; }
        public VocabularyKey ProjectGroup { get; private set; }
        public VocabularyKey ProjectContractID { get; private set; }
        public VocabularyKey ProjectType { get; private set; }
        public VocabularyKey ProjectStatus { get; private set; }
        public VocabularyKey ProjectedStartDate { get; private set; }
        public VocabularyKey ProjectedEndDate { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ParentId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ProjectManagerPersonnelNumber { get; private set; }
        public VocabularyKey SourceDataID { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }


    }
}