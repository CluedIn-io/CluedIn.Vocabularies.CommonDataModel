using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventNonConformanceResponsibleWorkerAssignmentEntityVocabulary : SimpleVocabulary
    {
        public InventNonConformanceResponsibleWorkerAssignmentEntityVocabulary()
        {
            VocabularyName = "Invent Non Conformance Responsible Worker Assignment Entity";
            KeyPrefix = "commonDataModel.inventnonconformanceresponsibleworkerassignmententity";
            KeySeparator = ".";
            Grouping = "/InventNonConformanceResponsibleWorkerAssignmentEntity";

            AddGroup("InventNonConformanceResponsibleWorkerAssignmentEntity Details", group =>
            {
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibleWorker = group.Add(new VocabularyKey(nameof(ResponsibleWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonConformanceReporterPersonnelNumber = group.Add(new VocabularyKey(nameof(NonConformanceReporterPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonConformanceResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(NonConformanceResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey ResponsibleWorker { get; private set; }
        public VocabularyKey NonConformanceReporterPersonnelNumber { get; private set; }
        public VocabularyKey NonConformanceResponsiblePersonnelNumber { get; private set; }
    }
}