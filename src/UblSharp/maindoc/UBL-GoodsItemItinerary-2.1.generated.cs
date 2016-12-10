// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UnqualifiedDataTypes;
    using CommonAggregateComponents;
    using CommonExtensionComponents;
    
    
    /// <summary>
    /// A document providing details relating to a transport service, such as transport movement, identification of equipment and goods, subcontracted service providers, etc.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Goods Item Itinerary. Details
    /// <para />ObjectClass: Goods Item Itinerary
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GoodsItemItinerary", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2")]
    [System.Xml.Serialization.XmlRootAttribute("GoodsItemItinerary", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2", IsNullable=false)]
    public partial class GoodsItemItineraryType : BaseDocument, IBaseDocument
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public TimeType @__IssueTime;
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public TextType[] @__Note
        {
            get
            {
                return _note?.ToArray();
            }
            set
            {
                _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public IdentifierType @__VersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TransportExecutionPlanReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public IdentifierType @__TransportExecutionPlanReferenceID;
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=13)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=14)]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public PartyType @__ReceiverParty;
        
        private System.Collections.Generic.List<ConsignmentType> _referencedConsignment;
        
        [System.Xml.Serialization.XmlElementAttribute("ReferencedConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public ConsignmentType[] @__ReferencedConsignment
        {
            get
            {
                return _referencedConsignment?.ToArray();
            }
            set
            {
                _referencedConsignment = value == null ? null : new System.Collections.Generic.List<ConsignmentType>(value);
            }
        }
        
        private System.Collections.Generic.List<TransportEquipmentType> _referencedTransportEquipment;
        
        [System.Xml.Serialization.XmlElementAttribute("ReferencedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public TransportEquipmentType[] @__ReferencedTransportEquipment
        {
            get
            {
                return _referencedTransportEquipment?.ToArray();
            }
            set
            {
                _referencedTransportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
            }
        }
        
        private System.Collections.Generic.List<PackageType> _referencedPackage;
        
        [System.Xml.Serialization.XmlElementAttribute("ReferencedPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public PackageType[] @__ReferencedPackage
        {
            get
            {
                return _referencedPackage?.ToArray();
            }
            set
            {
                _referencedPackage = value == null ? null : new System.Collections.Generic.List<PackageType>(value);
            }
        }
        
        private System.Collections.Generic.List<GoodsItemType> _referencedGoodsItem;
        
        [System.Xml.Serialization.XmlElementAttribute("ReferencedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public GoodsItemType[] @__ReferencedGoodsItem
        {
            get
            {
                return _referencedGoodsItem?.ToArray();
            }
            set
            {
                _referencedGoodsItem = value == null ? null : new System.Collections.Generic.List<GoodsItemType>(value);
            }
        }
        
        private System.Collections.Generic.List<TransportationSegmentType> _transportationSegment;
        
        [System.Xml.Serialization.XmlElementAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public TransportationSegmentType[] @__TransportationSegment
        {
            get
            {
                return _transportationSegment?.ToArray();
            }
            set
            {
                _transportationSegment = value == null ? null : new System.Collections.Generic.List<TransportationSegmentType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// A consignment being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Consignment. Consignment
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Consignment
        /// <para />AssociatedObjectClass: Consignment
        /// <para />RepresentationTerm: Consignment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ConsignmentType> ReferencedConsignment
        {
            get { return _referencedConsignment ?? (_referencedConsignment = new System.Collections.Generic.List<ConsignmentType>()); }
            set { _referencedConsignment = value; }
        }

        
        /// <summary>
        /// Transport equipment being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Transport Equipment. Transport Equipment
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Transport Equipment
        /// <para />AssociatedObjectClass: Transport Equipment
        /// <para />RepresentationTerm: Transport Equipment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TransportEquipmentType> ReferencedTransportEquipment
        {
            get { return _referencedTransportEquipment ?? (_referencedTransportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
            set { _referencedTransportEquipment = value; }
        }

        
        /// <summary>
        /// A package being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Package. Package
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Package
        /// <para />AssociatedObjectClass: Package
        /// <para />RepresentationTerm: Package
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<PackageType> ReferencedPackage
        {
            get { return _referencedPackage ?? (_referencedPackage = new System.Collections.Generic.List<PackageType>()); }
            set { _referencedPackage = value; }
        }

        
        /// <summary>
        /// An item of goods being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Goods Item. Goods Item
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Goods Item
        /// <para />AssociatedObjectClass: Goods Item
        /// <para />RepresentationTerm: Goods Item
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<GoodsItemType> ReferencedGoodsItem
        {
            get { return _referencedGoodsItem ?? (_referencedGoodsItem = new System.Collections.Generic.List<GoodsItemType>()); }
            set { _referencedGoodsItem = value; }
        }

        
        /// <summary>
        /// A part of a transport service that has its own Transport Execution Plan. A Transportation Segment may cover services other than transport, such as terminal handling, document management, customs procedures, etc.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Transportation Segment
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Transportation Segment
        /// <para />AssociatedObjectClass: Transportation Segment
        /// <para />RepresentationTerm: Transportation Segment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TransportationSegmentType> TransportationSegment
        {
            get { return _transportationSegment ?? (_transportationSegment = new System.Collections.Generic.List<TransportationSegmentType>()); }
            set { _transportationSegment = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Issue Time. Time
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// Identifies a version of a Goods Item Itinerary in order to distinguish updates.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Version. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType VersionID
        {
            get
            {
                if (__VersionID == null) { __VersionID = new IdentifierType(); }
                return __VersionID;
            }
            set
            {
                __VersionID = value;
            }
        }

        
        /// <summary>
        /// The Transport Execution Plan associated with this Goods Item Itinerary.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Transport Execution Plan Reference. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Transport Execution Plan Reference
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType TransportExecutionPlanReferenceID
        {
            get
            {
                if (__TransportExecutionPlanReferenceID == null) { __TransportExecutionPlanReferenceID = new IdentifierType(); }
                return __TransportExecutionPlanReferenceID;
            }
            set
            {
                __TransportExecutionPlanReferenceID = value;
            }
        }

        
        /// <summary>
        /// The sender of this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Sender_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Sender
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SenderParty
        {
            get
            {
                if (__SenderParty == null) { __SenderParty = new PartyType(); }
                return __SenderParty;
            }
            set
            {
                __SenderParty = value;
            }
        }

        
        /// <summary>
        /// The receiver of this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Receiver_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

    }
}