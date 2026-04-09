struct FileRecord{
	int offset; // Divided by 0x800
	int packedSize;
	short sectionCount;
	bool isCompressed;
	byte padding;
	int diskSize;
}
