using System;

namespace csharp.LorenzoSansone
{

	public class SeatImpl : ISeat
	{
		private readonly Row row;
		private readonly int column;

		public SeatImpl(Row row,int column)
		{
			this.row = row;
			this.column = column;
		}

		public Row RowSeat
		{
			get
			{
				return this.row;
			}
		}
		
		public int ColumnSeat
		{
			get
			{
				return this.column;
			}
		}
		public override bool Equals(object obj)
		{
			return obj is SeatImpl impl &&
				row == impl.row &&
				column == impl.column;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(column, row);
		}
		
		public override string ToString()
		{
			return "SeatImpl [row=" + row + ", column=" + column + "]";
		}
	}

}
