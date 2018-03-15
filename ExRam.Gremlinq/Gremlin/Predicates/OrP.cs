using System.Text;

namespace ExRam.Gremlinq
{
    internal struct OrP : IGremlinSerializable
    {
        private readonly P[] _predicates;

        public OrP(params P[] predicates)
        {
            this._predicates = predicates;
        }

        public void Serialize(StringBuilder builder, IParameterCache parameterCache)
        {
            for (var i = 0; i < this._predicates.Length; i++)
            {
                if (i != 0)
                    builder.Append(".or(");

                this._predicates[i].Serialize(builder, parameterCache);

                if (i != 0)
                    builder.Append(")");
            }
        }
    }
}