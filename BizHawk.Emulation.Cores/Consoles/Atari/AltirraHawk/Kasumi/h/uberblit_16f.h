#ifndef f_VD2_KASUMI_UBERBLIT_16F_H
#define f_VD2_KASUMI_UBERBLIT_16F_H

#include <vd2/system/cpuaccel.h>
#include "uberblit_base.h"

///////////////////////////////////////////////////////////////////////////////////////////////////
//
//	32F -> 16F
//
///////////////////////////////////////////////////////////////////////////////////////////////////

class VDPixmapGen_32F_To_16F : public VDPixmapGenWindowBasedOneSourceSimple {
public:
	void Start();

	uint32 GetType(uint32 output) const;

protected:
	void Compute(void *dst0, sint32 y);
};

///////////////////////////////////////////////////////////////////////////////////////////////////
//
//	16F -> 32F
//
///////////////////////////////////////////////////////////////////////////////////////////////////

class VDPixmapGen_16F_To_32F : public VDPixmapGenWindowBasedOneSourceSimple {
public:
	void Start();

	uint32 GetType(uint32 output) const;

protected:
	void Compute(void *dst0, sint32 y);
};

#endif
