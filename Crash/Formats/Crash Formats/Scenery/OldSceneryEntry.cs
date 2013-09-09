using System;
using System.Collections.Generic;

namespace Crash
{
    public sealed class OldSceneryEntry : Entry
    {
        private byte[] info;
        private List<OldSceneryPolygon> polygons;
        private List<OldSceneryVertex> vertices;

        public OldSceneryEntry(byte[] info,IEnumerable<OldSceneryPolygon> polygons,IEnumerable<OldSceneryVertex> vertices,int eid) : base(eid)
        {
            this.info = info;
            this.polygons = new List<OldSceneryPolygon>(polygons);
            this.vertices = new List<OldSceneryVertex>(vertices);
        }

        public override int Type
        {
            get { return 3; }
        }

        public byte[] Info
        {
            get { return info; }
        }

        public IList<OldSceneryPolygon> Polygons
        {
            get { return polygons; }
        }

        public IList<OldSceneryVertex> Vertices
        {
            get { return vertices; }
        }

        public override UnprocessedEntry Unprocess()
        {
            throw new NotImplementedException();
        }
    }
}