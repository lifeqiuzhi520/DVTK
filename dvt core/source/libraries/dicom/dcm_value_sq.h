//*****************************************************************************
// Part of Dvtk Libraries - Internal Native Library Code
// Copyright � 2001-2006
// Philips Medical Systems NL B.V., Agfa-Gevaert N.V.
//*****************************************************************************
#ifndef DCM_VALUE_SQ_H
#define DCM_VALUE_SQ_H

//*****************************************************************************
//  EXTERNAL DECLARATIONS
//*****************************************************************************
#include "Iglobal.h"			// Global component interface
#include "Ilog.h"				// Log component interface
#include "Iutility.h"			// Utility component interface
#include "Iwarehouse.h"			// Warehouse component interface
#include "IAttributeGroup.h"	// Attribute component interface


//*****************************************************************************
//  FORWARD DECLARATION
//*****************************************************************************
class PRIVATE_ATTRIBUTE_HANDLER_CLASS;
class DCM_ATTRIBUTE_CLASS;
class DCM_ITEM_CLASS;


//>>***************************************************************************
class DCM_VALUE_SQ_CLASS : public VALUE_SQ_CLASS

//  DESCRIPTION     : SQ value class.
//  INVARIANT       :
//  NOTES           :
//<<***************************************************************************
{
private:
	int								nestingDepthM;
	bool							definedLengthM;
	UINT16							delimiterGroupM;
	UINT16							delimiterElementM;
	UINT32							delimiterLengthM;
	DCM_ATTRIBUTE_CLASS				*parentM_ptr;
	PRIVATE_ATTRIBUTE_HANDLER_CLASS	*pahM_ptr;
	LOG_CLASS						*loggerM_ptr;

public:
	DCM_VALUE_SQ_CLASS(UINT32);

	~DCM_VALUE_SQ_CLASS();

	void setDefinedLength(bool);

	void setDelimiterGroup(UINT16 group)
		{ delimiterGroupM = group; }

	void setDelimiterElement(UINT16 element)
		{ delimiterElementM = element; }

	bool isDefinedLength()
		{ return definedLengthM; }

	UINT16 getDelimiterGroup()
		{ return delimiterGroupM; }

	UINT16 getDelimiterElement()
		{ return delimiterElementM; }

	UINT32 getDelimiterLength()
		{ return delimiterLengthM; }

	void addItem(DCM_ITEM_CLASS*);

	DCM_ITEM_CLASS* getItem(UINT);

	void setNestingDepth(int);

	void setTransferVR(TRANSFER_ATTR_VR_ENUM);

	void setDefineGroupLengths(bool);

	void setGroupLengths(TS_CODE);

	void addGroupLengths();

	void merge(DCM_ATTRIBUTE_CLASS*);

	UINT32 computeLength(TS_CODE);

	void computeItemOffsets(DATA_TF_CLASS&, UINT32*);

	bool encode(DATA_TF_CLASS&);

	bool decode(DATA_TF_CLASS&);

    DCM_ITEM_CLASS* decodeNextItem(DATA_TF_CLASS&);

	bool operator == (BASE_VALUE_CLASS*);
	
	bool operator != (BASE_VALUE_CLASS*);

    bool operator = (DCM_VALUE_SQ_CLASS&);

	void setLogger(LOG_CLASS*);

	void setParent(DCM_ATTRIBUTE_CLASS *parent_ptr)
		{ parentM_ptr = parent_ptr; }

	DCM_ATTRIBUTE_CLASS* getParent()
		{ return parentM_ptr; }

	void setPAH(PRIVATE_ATTRIBUTE_HANDLER_CLASS *pah_ptr)
		{ pahM_ptr = pah_ptr; }
};

#endif /* DCM_VALUE_SQ_H */

