﻿// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright © 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>

using System.IO;
using DvtkData.DvtDetailToXml;

// 
// This source code was auto-generated by xsd, Version=1.1.4322.573.
// 
namespace DvtkData.Media 
{
    using DvtkData.Dimse;
    using DvtkData.Validation;

    /// <summary>
    /// File meta information.
    /// </summary>
    /// <remarks>Part of <see cref="DvtkData.Media.DicomFile"/>.</remarks>
    public class FileMetaInformation : AttributeSet 
	{
		/// <summary>
		/// Serialize DVT Detail Data to Xml.
		/// </summary>
		/// <param name="streamWriter">Stream writer to serialize to.</param>
		/// <param name="level">Recursion level. 0 = Top.</param> 
		/// <returns>bool - success/failure</returns>
		public override bool DvtDetailToXml(StreamWriter streamWriter, int level)
		{
			bool result = false;

			streamWriter.WriteLine("<FileMetaInformation>");
			foreach (Attribute attribute in this)
			{
				result = attribute.DvtDetailToXml(streamWriter, level);
			}
			streamWriter.WriteLine("</FileMetaInformation>");

			return result;
		}	
	}

    /// <summary>
    /// Directory records.
    /// </summary>
    /// <remarks>Directory records are part of dicomdir.</remarks>
    public class DirectoryRecord : AttributeSet
    {
        /// <summary>
        /// Identifies the type of directory record.
        /// </summary>
        public string DirectoryRecordType
        {
            get
            {
                return _DirectoryRecordType;
            }
            set
            {
                _DirectoryRecordType = value;
            }
        }
        private string _DirectoryRecordType;
        
        /// <summary>
        /// Corresponding referenced file
        /// </summary>
        public string ReferencedFile
        {
            get
            {
                return _ReferencedFile;
            }
            set
            {
                _ReferencedFile = value;
            }
        }
        private string _ReferencedFile;
        
        /// <summary>
		/// Serialize DVT Detail Data to Xml.
		/// </summary>
		/// <param name="streamWriter">Stream writer to serialize to.</param>
		/// <param name="level">Recursion level. 0 = Top.</param> 
		/// <returns>bool - success/failure</returns>
		public override bool DvtDetailToXml(StreamWriter streamWriter, int level)
		{
			bool result = false;
			streamWriter.WriteLine("<Dataset>");
			foreach (Attribute attribute in this)
			{
				result = attribute.DvtDetailToXml(streamWriter, level);
			}
			streamWriter.WriteLine("</Dataset>");
			return result;
		}
    }

    /// <summary>
    /// Type-safe DirectoryRecordCollection
    /// </summary>
    public sealed class DirectoryRecordCollection
        : DvtkData.Collections.NullSafeCollectionBase, IDvtDetailToXml, IDvtSummaryToXml
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public DirectoryRecordCollection() { }

        /// <summary>
        /// Constructor with initialization. Shallow copy.
        /// </summary>
        /// <param name="arrayOfValues">values to copy.</param>
        /// <exception cref="System.ArgumentNullException">Argument <c>arrayOfValues</c> is a <see langword="null"/> reference.</exception>
        public DirectoryRecordCollection(
            DirectoryRecord[] arrayOfValues)
        {
            if (arrayOfValues == null) throw new System.ArgumentNullException();
            foreach (DirectoryRecord value in arrayOfValues) this.Add(value);
        }

        /// <summary>
        /// Gets or sets the item at the specified index.
        /// </summary>
        /// <value>The item at the specified <c>index</c>.</value>
        public new DirectoryRecord this[int index]
        {
            get { return (DirectoryRecord)base[index]; }
            set { base.Insert(index, value); }
        }

        /// <summary>
        /// Inserts an item to the IList at the specified position.
        /// </summary>
        /// <param name="index">The zero-based index at which <c>value</c> should be inserted. </param>
        /// <param name="value">The item to insert into the <see cref="System.Collections.IList"/>.</param>
        public void Insert(int index, DirectoryRecord value)
        {
            base.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurrence of a specific item from the IList.
        /// </summary>
        /// <param name="value">The item to remove from the <see cref="System.Collections.IList"/>.</param>
        public void Remove(DirectoryRecord value)
        {
            base.Remove(value);
        }

        /// <summary>
        /// Determines whether the <see cref="System.Collections.IList"/> contains a specific item.
        /// </summary>
        /// <param name="value">The item to locate in the <see cref="System.Collections.IList"/>.</param>
        /// <returns><see langword="true"/> if the item is found in the <see cref="System.Collections.IList"/>; otherwise, <see langword="false"/>.</returns>
        public bool Contains(DirectoryRecord value)
        {
            return base.Contains(value);
        }

        /// <summary>
        /// Determines the index of a specific item in the <see cref="System.Collections.IList"/>.
        /// </summary>
        /// <param name="value">The item to locate in the <see cref="System.Collections.IList"/>.</param>
        /// <returns>The index of <c>value</c> if found in the list; otherwise, -1.</returns>
        public int IndexOf(DirectoryRecord value)
        {
            return base.IndexOf(value);
        }

        /// <summary>
        /// Adds an item to the <see cref="System.Collections.IList"/>.
        /// </summary>
        /// <param name="value">The item to add to the <see cref="System.Collections.IList"/>. </param>
        /// <returns>The position into which the new element was inserted.</returns>
        public int Add(DirectoryRecord value)
        {
            return base.Add(value);
        }

        /// <summary>
        /// Serialize DVT Detail Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtDetailToXml(StreamWriter streamWriter, int level)
        {
            bool result = true;

            if (this.Count != 0)
            {
                streamWriter.WriteLine("<DirectoryRecordLinks>");
                foreach (DirectoryRecord directoryRecord in this)
                {
                    result = directoryRecord.DvtDetailToXml(streamWriter, level);
                }
                streamWriter.WriteLine("</DirectoryRecordLinks>");
            }

            return result;
        }

        /// <summary>
        /// Serialize DVT Summary Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtSummaryToXml(StreamWriter streamWriter, int level)
        {
            bool result = true;

            if (this.Count != 0)
            {
                streamWriter.WriteLine("<DirectoryRecordLinks>");
                foreach (DirectoryRecord directoryRecord in this)
                {
                    //result = directoryRecord.DvtSummaryToXml(streamWriter, level);
                }
                streamWriter.WriteLine("</DirectoryRecordLinks>");
            }

            return result;
        }
    }

    /// <summary>
    /// A DICOM File is a File with a content formatted according to the requirements of Part 10 of
    /// the DICOM Standard. In particular such files shall contain, the File Meta Information and a properly
    /// formatted Data Set.
    /// </summary>
    public class DicomFile : IDvtDetailToXml
	{
        
        /// <summary>
        /// Contains the File Preamble, DICOM Prefix and Transfer Syntax UID.
        /// </summary>
        /// <remarks>
        /// In the DICOM standard, this FileHead is actually part of the File Meta Information.
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public FileHead FileHead 
		{
			get 
            { 
                return _FileHead; 
            }
			set 
            { 
                if (value == null) throw new System.ArgumentNullException();
                _FileHead = value; 
            }
		} 
        private FileHead _FileHead = new FileHead();
        
        /// <summary>
        /// The File Meta Information includes identifying information on the encapsulated Data Set. 
        /// It is a mandatory header at the beginning of every DICOM File.
        /// </summary>
        /// <remarks>
        /// In the DICOM standard, this FileHead is actually part of the File Meta Information.
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public FileMetaInformation FileMetaInformation 
		{
			get 
            {
                return _FileMetaInformation; 
            }
			set 
            { 
                if (value == null) throw new System.ArgumentNullException();
                _FileMetaInformation = value; 
            }
		} 
        private FileMetaInformation _FileMetaInformation = new FileMetaInformation();
        
        /// <summary>
        /// Each File shall contain a single Data Set representing a single SOP Instance 
        /// related to a single SOP Class (and corresponding IOD).
        /// </summary>
        /// <remarks>
        /// <p>
        /// The Transfer Syntax used to encode the Data Set shall be the one identified by the Transfer Syntax UID
        /// of the DICOM File Meta Information.
        /// </p>
        /// <p>
        /// The last Data Element of a Data Set may be Data Element (FFFC,FFFC) if padding of a Data Set is
        /// desired when a file is written. The Value of this Data Set Trailing Padding Data Element (FFFC,FFFC)
        /// has no significance and shall be ignored by all DICOM implementations reading this Data Set.
        /// </p>
        /// <p>
        /// File-set Readers or Updaters shall be able to process this Data Set Trailing Padding (FFFC,FFFC) 
        /// either in the Data Set following the Meta Information or in Data Sets 
        /// nested in a Sequence (See PS 3.5 of the DICOM Standard).
        /// </p>
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public DataSet DataSet 
        {
            get 
            { 
                return _DataSet; 
            }
            set 
            { 
                if (value == null) throw new System.ArgumentNullException();
                _DataSet = value; 
            }
        } 
        private DataSet _DataSet = new DataSet();

		/// <summary>
		/// Serialize DVT Detail Data to Xml.
		/// </summary>
		/// <param name="streamWriter">Stream writer to serialize to.</param>
		/// <param name="level">Recursion level. 0 = Top.</param> 
		/// <returns>bool - success/failure</returns>
		public bool DvtDetailToXml(StreamWriter streamWriter, int level)
		{
			FileHead.DvtDetailToXml(streamWriter, level);
			FileMetaInformation.DvtDetailToXml(streamWriter, level);
			DataSet.DvtDetailToXml(streamWriter, level);

			return true;
		}
    }

    /// <summary>
    /// A DICOMDIR File is a File with a content formatted according to the requirements of Part 10 of
    /// the DICOM Standard. In particular such files shall contain, the File Meta Information and a properly
    /// formatted Data Set.
    /// </summary>
    public class DicomDir : IDvtDetailToXml
    {
        /// <summary>
        /// Contains the File Preamble, DICOM Prefix and Transfer Syntax UID.
        /// </summary>
        /// <remarks>
        /// In the DICOM standard, this FileHead is actually part of the File Meta Information.
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public FileHead FileHead
        {
            get
            {
                return _FileHead;
            }
            set
            {
                if (value == null) throw new System.ArgumentNullException();
                _FileHead = value;
            }
        }
        private FileHead _FileHead = new FileHead();

        /// <summary>
        /// The File Meta Information includes identifying information on the encapsulated Data Set. 
        /// It is a mandatory header at the beginning of every DICOM File.
        /// </summary>
        /// <remarks>
        /// In the DICOM standard, this FileHead is actually part of the File Meta Information.
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public FileMetaInformation FileMetaInformation
        {
            get
            {
                return _FileMetaInformation;
            }
            set
            {
                if (value == null) throw new System.ArgumentNullException();
                _FileMetaInformation = value;
            }
        }
        private FileMetaInformation _FileMetaInformation = new FileMetaInformation();

        /// <summary>
        /// Each File shall contain a single Data Set representing a single SOP Instance 
        /// related to a single SOP Class (and corresponding IOD).
        /// </summary>
        /// <remarks>
        /// <p>
        /// The Transfer Syntax used to encode the Data Set shall be the one identified by the Transfer Syntax UID
        /// of the DICOM File Meta Information.
        /// </p>
        /// <p>
        /// The last Data Element of a Data Set may be Data Element (FFFC,FFFC) if padding of a Data Set is
        /// desired when a file is written. The Value of this Data Set Trailing Padding Data Element (FFFC,FFFC)
        /// has no significance and shall be ignored by all DICOM implementations reading this Data Set.
        /// </p>
        /// <p>
        /// File-set Readers or Updaters shall be able to process this Data Set Trailing Padding (FFFC,FFFC) 
        /// either in the Data Set following the Meta Information or in Data Sets 
        /// nested in a Sequence (See PS 3.5 of the DICOM Standard).
        /// </p>
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public DataSet DataSet
        {
            get
            {
                return _DataSet;
            }
            set
            {
                if (value == null) throw new System.ArgumentNullException();
                _DataSet = value;
            }
        }
        private DataSet _DataSet = new DataSet();

        /// <summary>
        /// Array of Directory Records
        /// </summary>
        public DirectoryRecordCollection DirectoryRecords
        {
            get
            {
                return _DirectoryRecords;
            }
            set
            {
                _DirectoryRecords = value;
            }
        }
        private DirectoryRecordCollection _DirectoryRecords = new DirectoryRecordCollection();

        /// <summary>
        /// Serialize DVT Detail Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtDetailToXml(StreamWriter streamWriter, int level)
        {
            FileHead.DvtDetailToXml(streamWriter, level);
            FileMetaInformation.DvtDetailToXml(streamWriter, level);
            DataSet.DvtDetailToXml(streamWriter, level);

            return true;
        }
    }
    
    /// <summary>
    /// Contains the File Preamble, DICOM Prefix and Transfer Syntax UID.
    /// </summary>
    /// <remarks>
    /// In the DICOM standard, this FileHead is actually part of the File Meta Information.
    /// </remarks>
    public class FileHead : IDvtDetailToXml
    {
        
        /// <summary>
        /// A fixed 128 byte field available for Application Profile or
        /// implementation specified use. If not used by an Application
        /// Profile or a specific implementation all bytes shall be set to 00H.
        /// </summary>
        /// <exception cref="System.ArgumentException">Preamble should have a length of 128 bytes.</exception>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public System.Byte[] FilePreamble 
		{
			get 
            { 
                return _FilePreamble; 
            }
			set 
            { 
                if (value == null)
                {
                    throw new System.ArgumentNullException();
                }
                if (value.Length != 128)
                {
                    throw new System.ArgumentException("Preamble should have a length of 128 bytes.");
                }
                _FilePreamble = value; 
            }
		} 
        private System.Byte[] _FilePreamble = new System.Byte[128];
        
        /// <summary>
        /// Four bytes containing the character string "DICM". 
        /// This Prefix is intended to be used to recognize that this File is or is not a DICOM File.
        /// </summary>
        /// <remarks>A different Prefix may be specified</remarks>
        /// <exception cref="System.ArgumentException">Dicom Prefix should have a length of 4 bytes.</exception>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public System.Byte[] DicomPrefix 
		{
			get 
            { 
                return _DicomPrefix; 
            }
			set 
            { 
                if (value == null)
                {
                    throw new System.ArgumentNullException();
                }
                if (value.Length != 4)
                {
                    throw new System.ArgumentException("Dicom Prefix should have a length of 4 bytes.");
                }
                _DicomPrefix = value; 
            }
		} 
        private System.Byte[] _DicomPrefix = new System.Byte[4] {D,I,C,M};
        const System.Byte D=68, I=73, C=67, M=77;
        
        /// <summary>
        /// Uniquely identifies the Transfer Syntax used to encode the
        /// following Data Set. This Transfer Syntax does not apply to
        /// the File Meta Information.
        /// </summary>
        /// <remarks>
        /// Note: It is recommended to use one of the DICOM Transfer
        /// Syntaxes supporting explicit Value Representation
        /// encoding to facilitate interpretation of File Meta
        /// Element Values (See PS 3.5 of the DICOM Standard).
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">Argument is a <see langword="null"/> reference.</exception>
        public DvtkData.Dul.TransferSyntax TransferSyntax 
		{
			get 
            { 
                return _TransferSyntax; 
            }
			set 
            { 
                if (value == null) throw new System.ArgumentNullException();
                _TransferSyntax = value; 
            }
		} 
        private DvtkData.Dul.TransferSyntax _TransferSyntax = 
            DvtkData.Dul.TransferSyntax.Explicit_VR_Little_Endian;

		/// <summary>
		/// Serialize DVT Detail Data to Xml.
		/// </summary>
		/// <param name="streamWriter">Stream writer to serialize to.</param>
		/// <param name="level">Recursion level. 0 = Top.</param> 
		/// <returns>bool - success/failure</returns>
		public bool DvtDetailToXml(StreamWriter streamWriter, int level)
		{
			streamWriter.WriteLine("<FileHead>");
			streamWriter.WriteLine("<FilePreamble>");
			foreach (System.Byte byteValue in FilePreamble)
			{
				string byteValueString = byteValue.ToString("X");
				while (byteValueString.Length < 2)
				{
					byteValueString = "0" + byteValueString;
				}
				streamWriter.Write(byteValueString);
			}
			streamWriter.WriteLine("</FilePreamble>");
			streamWriter.WriteLine("<DicomPrefix>");
			foreach (System.Byte byteValue in DicomPrefix)
			{
				streamWriter.Write(byteValue.ToString());
			}
			streamWriter.WriteLine("</DicomPrefix>");
			streamWriter.WriteLine("<TransferSyntax>{0}</TransferSyntax>", TransferSyntax.UID);
			streamWriter.WriteLine("</FileHead>");
			return true;
		}
    }
}
