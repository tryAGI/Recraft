#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GenerateImageRequest : global::System.IEquatable<GenerateImageRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.GenerateImageRequestBase? Base { get; init; }
#else
        public global::Recraft.GenerateImageRequestBase? Base { get; }
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
            out global::Recraft.GenerateImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.GenerateImageRequestVariant2? GenerateImageRequestVariant2 { get; init; }
#else
        public global::Recraft.GenerateImageRequestVariant2? GenerateImageRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateImageRequestVariant2))]
#endif
        public bool IsGenerateImageRequestVariant2 => GenerateImageRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGenerateImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.GenerateImageRequestVariant2? value)
        {
            value = GenerateImageRequestVariant2;
            return IsGenerateImageRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageRequestVariant2 PickGenerateImageRequestVariant2() => IsGenerateImageRequestVariant2
            ? GenerateImageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GenerateImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateImageRequest(global::Recraft.GenerateImageRequestBase value) => new GenerateImageRequest((global::Recraft.GenerateImageRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.GenerateImageRequestBase?(GenerateImageRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public GenerateImageRequest(global::Recraft.GenerateImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateImageRequest FromBase(global::Recraft.GenerateImageRequestBase? value) => new GenerateImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateImageRequest(global::Recraft.GenerateImageRequestVariant2 value) => new GenerateImageRequest((global::Recraft.GenerateImageRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.GenerateImageRequestVariant2?(GenerateImageRequest @this) => @this.GenerateImageRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public GenerateImageRequest(global::Recraft.GenerateImageRequestVariant2? value)
        {
            GenerateImageRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateImageRequest FromGenerateImageRequestVariant2(global::Recraft.GenerateImageRequestVariant2? value) => new GenerateImageRequest(value);

        /// <summary>
        ///
        /// </summary>
        public GenerateImageRequest(
            global::Recraft.GenerateImageRequestBase? @base,
            global::Recraft.GenerateImageRequestVariant2? generateImageRequestVariant2
            )
        {
            Base = @base;
            GenerateImageRequestVariant2 = generateImageRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GenerateImageRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GenerateImageRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGenerateImageRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.GenerateImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.GenerateImageRequestVariant2, TResult>? generateImageRequestVariant2 = null,
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
            else if (IsGenerateImageRequestVariant2 && generateImageRequestVariant2 != null)
            {
                return generateImageRequestVariant2(GenerateImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.GenerateImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.GenerateImageRequestVariant2>? generateImageRequestVariant2 = null,
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
            else if (IsGenerateImageRequestVariant2)
            {
                generateImageRequestVariant2?.Invoke(GenerateImageRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.GenerateImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.GenerateImageRequestVariant2>? generateImageRequestVariant2 = null,
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
            else if (IsGenerateImageRequestVariant2)
            {
                generateImageRequestVariant2?.Invoke(GenerateImageRequestVariant2!);
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
                typeof(global::Recraft.GenerateImageRequestBase),
                GenerateImageRequestVariant2,
                typeof(global::Recraft.GenerateImageRequestVariant2),
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
        public bool Equals(GenerateImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.GenerateImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.GenerateImageRequestVariant2?>.Default.Equals(GenerateImageRequestVariant2, other.GenerateImageRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GenerateImageRequest obj1, GenerateImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GenerateImageRequest obj1, GenerateImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateImageRequest o && Equals(o);
        }
    }
}
