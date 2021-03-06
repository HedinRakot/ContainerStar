using System;

namespace MetadataLoader.TTIncludes.MasterDataModule.Entities
{
    /// <summary>
    ///     EN: Reference table: Recognition Type - Class  DE: Zuordnungstabelle Anerkennungsgrad - FE-Klasse
    /// </summary>
    public partial class ExamRecognitionTypeExamClass
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "DATA.DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="ExamRecognitionTypeExamClass.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'DRL_EXAM_RECOGNITION_TYPE_ID' for property <see cref="ExamRecognitionTypeExamClass.ExamRecognitionTypeId"/>
            /// </summary>
            public static readonly string ExamRecognitionTypeId = "DRL_EXAM_RECOGNITION_TYPE_ID";
            /// <summary>
            /// Column name 'DRL_EXAM_CLASS_ID' for property <see cref="ExamRecognitionTypeExamClass.ExamClassId"/>
            /// </summary>
            public static readonly string ExamClassId = "DRL_EXAM_CLASS_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="ExamRecognitionTypeExamClass.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="ExamRecognitionTypeExamClass.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="ExamRecognitionTypeExamClass.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="ExamRecognitionTypeExamClass.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="ExamRecognitionTypeExamClass.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="ExamRecognitionTypeExamClass.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="ExamRecognitionTypeExamClass.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="ExamRecognitionTypeExamClass.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="ExamRecognitionTypeExamClass.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="ExamRecognitionTypeExamClass.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        /// <summary>
        ///     EN: PK  DE: Primaerschluessel
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        ///     EN: Recognition Type  DE: Anerkennungsgrad
        /// </summary>
        public int ExamRecognitionTypeId{ get; set; }
        /// <summary>
        ///     EN: Class  DE: FE-Klasse
        /// </summary>
        public int ExamClassId{ get; set; }
        /// <summary>
        ///     ANLAGEDATUM (INSERT-DATUM)
        /// </summary>
        public DateTime CreateDate{ get; set; }
        /// <summary>
        ///     AENDERUNGSDATUM (UPDATE-DATUM)
        /// </summary>
        public DateTime ChangeDate{ get; set; }
        /// <summary>
        ///     LOESCHDATUM FUER LOGISCHE LOESCHUNG VON DATENSAETZEN (DELETE-DATUM)
        /// </summary>
        public DateTime? DeleteDate{ get; set; }
        /// <summary>
        ///     OWNER (SCHLUESSEL EINER ORGANISATIONSEINHEIT, WELCHE FUER DIE PFLEGE EINES DATENSATZES
        /// </summary>
        public int? OwnerOrgId{ get; set; }
        /// <summary>
        ///     SICHTBARKEIT (SCHLUESSEL EINER ORGANISATIONSEINHEIT, AB WELCHER IM HIERACHIEBAUM ABWAERTS EIN DATENSATZ SICHTBAR IST)
        /// </summary>
        public int? VisibilityOrgId{ get; set; }
        /// <summary>
        ///     ANLEGER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ANGELEGT HAT)
        /// </summary>
        public int? CreateEmployeeId{ get; set; }
        /// <summary>
        ///     AENDERER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ALS LETZTES GEAENDERT HAT, BEI NEUANLAGE IST DIESER WERT GLEICH DEM ANLEGER)
        /// </summary>
        public int? ChangeEmployeeId{ get; set; }
        /// <summary>
        ///     QUELLSYSTEM
        /// </summary>
        public string Source{ get; set; }
        /// <summary>
        ///     VON-DATUM DER GUELTIGKEIT
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     ENDE-DATUM DER GUELTIGKEIT
        /// </summary>
        public DateTime ToDate{ get; set; }
        public virtual ExamClass ExamClass{ get; set; }
        public virtual ExamRecognitionType ExamRecognitionType{ get; set; }
        public bool HasExamClass{
            get { return !ReferenceEquals(ExamClass, null); }
        }
        public bool HasExamRecognitionType{
            get { return !ReferenceEquals(ExamRecognitionType, null); }
        }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public ExamRecognitionTypeExamClass ShallowCopy()
        {
            return new ExamRecognitionTypeExamClass {
                       ExamRecognitionTypeId = ExamRecognitionTypeId,
                       ExamClassId = ExamClassId,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       OwnerOrgId = OwnerOrgId,
                       VisibilityOrgId = VisibilityOrgId,
                       CreateEmployeeId = CreateEmployeeId,
                       ChangeEmployeeId = ChangeEmployeeId,
                       Source = Source,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
