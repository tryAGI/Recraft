#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RefineDetailsRequest : global::System.IEquatable<RefineDetailsRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.RefineDetailsRequestBase? Base { get; init; }
#else
        public global::Recraft.RefineDetailsRequestBase? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.RefineDetailsRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.RefineDetailsRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.RefineDetailsRequestVariant2? RefineDetailsRequestVariant2 { get; init; }
#else
        public global::Recraft.RefineDetailsRequestVariant2? RefineDetailsRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefineDetailsRequestVariant2))]
#endif
        public bool IsRefineDetailsRequestVariant2 => RefineDetailsRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefineDetailsRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.RefineDetailsRequestVariant2? value)
        {
            value = RefineDetailsRequestVariant2;
            return IsRefineDetailsRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.RefineDetailsRequestVariant2 PickRefineDetailsRequestVariant2() => IsRefineDetailsRequestVariant2
            ? RefineDetailsRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefineDetailsRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RefineDetailsRequest(global::Recraft.RefineDetailsRequestBase value) => new RefineDetailsRequest((global::Recraft.RefineDetailsRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.RefineDetailsRequestBase?(RefineDetailsRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public RefineDetailsRequest(global::Recraft.RefineDetailsRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RefineDetailsRequest FromBase(global::Recraft.RefineDetailsRequestBase? value) => new RefineDetailsRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RefineDetailsRequest(global::Recraft.RefineDetailsRequestVariant2 value) => new RefineDetailsRequest((global::Recraft.RefineDetailsRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.RefineDetailsRequestVariant2?(RefineDetailsRequest @this) => @this.RefineDetailsRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public RefineDetailsRequest(global::Recraft.RefineDetailsRequestVariant2? value)
        {
            RefineDetailsRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RefineDetailsRequest FromRefineDetailsRequestVariant2(global::Recraft.RefineDetailsRequestVariant2? value) => new RefineDetailsRequest(value);

        /// <summary>
        ///
        /// </summary>
        public RefineDetailsRequest(
            global::Recraft.RefineDetailsRequestBase? @base,
            global::Recraft.RefineDetailsRequestVariant2? refineDetailsRequestVariant2
            )
        {
            Base = @base;
            RefineDetailsRequestVariant2 = refineDetailsRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RefineDetailsRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            RefineDetailsRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsRefineDetailsRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.RefineDetailsRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.RefineDetailsRequestVariant2, TResult>? refineDetailsRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsRefineDetailsRequestVariant2 && refineDetailsRequestVariant2 != null)
            {
                return refineDetailsRequestVariant2(RefineDetailsRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.RefineDetailsRequestBase>? @base = null,

            global::System.Action<global::Recraft.RefineDetailsRequestVariant2>? refineDetailsRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsRefineDetailsRequestVariant2)
            {
                refineDetailsRequestVariant2?.Invoke(RefineDetailsRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.RefineDetailsRequestBase>? @base = null,
            global::System.Action<global::Recraft.RefineDetailsRequestVariant2>? refineDetailsRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsRefineDetailsRequestVariant2)
            {
                refineDetailsRequestVariant2?.Invoke(RefineDetailsRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Recraft.RefineDetailsRequestBase),
                RefineDetailsRequestVariant2,
                typeof(global::Recraft.RefineDetailsRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(RefineDetailsRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.RefineDetailsRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.RefineDetailsRequestVariant2?>.Default.Equals(RefineDetailsRequestVariant2, other.RefineDetailsRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RefineDetailsRequest obj1, RefineDetailsRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RefineDetailsRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RefineDetailsRequest obj1, RefineDetailsRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RefineDetailsRequest o && Equals(o);
        }
    }
}
