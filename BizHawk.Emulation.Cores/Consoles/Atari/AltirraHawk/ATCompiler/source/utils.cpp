//	Altirra - Atari 800/800XL/5200 emulator
//	Compiler - Misc utilities
//	Copyright (C) 2009-2012 Avery Lee
//
//	This program is free software; you can redistribute it and/or modify
//	it under the terms of the GNU General Public License as published by
//	the Free Software Foundation; either version 2 of the License, or
//	(at your option) any later version.
//
//	This program is distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//	GNU General Public License for more details.
//
//	You should have received a copy of the GNU General Public License
//	along with this program; if not, write to the Free Software
//	Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.

#include <stdafx.h>

void fail(const char *msg, ...) {
	va_list val;

	fprintf(stderr, "ERROR: ");
	va_start(val, msg);
	vfprintf(stderr, msg, val);
	va_end(val);
	fputc('\n', stderr);

	exit(20);
}
