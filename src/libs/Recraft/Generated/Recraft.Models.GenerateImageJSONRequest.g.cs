#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GenerateImageJSONRequest : global::System.IEquatable<GenerateImageJSONRequest>
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
        public global::Recraft.GenerateImageJSONRequestVariant2? GenerateImageJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.GenerateImageJSONRequestVariant2? GenerateImageJSONRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateImageJSONRequestVariant2))]
#endif
        public bool IsGenerateImageJSONRequestVariant2 => GenerateImageJSONRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGenerateImageJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.GenerateImageJSONRequestVariant2? value)
        {
            value = GenerateImageJSONRequestVariant2;
            return IsGenerateImageJSONRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageJSONRequestVariant2 PickGenerateImageJSONRequestVariant2() => IsGenerateImageJSONRequestVariant2
            ? GenerateImageJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GenerateImageJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateImageJSONRequest(global::Recraft.GenerateImageRequestBase value) => new GenerateImageJSONRequest((global::Recraft.GenerateImageRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.GenerateImageRequestBase?(GenerateImageJSONRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public GenerateImageJSONRequest(global::Recraft.GenerateImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateImageJSONRequest FromBase(global::Recraft.GenerateImageRequestBase? value) => new GenerateImageJSONRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateImageJSONRequest(global::Recraft.GenerateImageJSONRequestVariant2 value) => new GenerateImageJSONRequest((global::Recraft.GenerateImageJSONRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Recraft.GenerateImageJSONRequestVariant2?(GenerateImageJSONRequest @this) => @this.GenerateImageJSONRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public GenerateImageJSONRequest(global::Recraft.GenerateImageJSONRequestVariant2? value)
        {
            GenerateImageJSONRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateImageJSONRequest FromGenerateImageJSONRequestVariant2(global::Recraft.GenerateImageJSONRequestVariant2? value) => new GenerateImageJSONRequest(value);

        /// <summary>
        ///
        /// </summary>
        public GenerateImageJSONRequest(
            global::Recraft.GenerateImageRequestBase? @base,
            global::Recraft.GenerateImageJSONRequestVariant2? generateImageJSONRequestVariant2
            )
        {
            Base = @base;
            GenerateImageJSONRequestVariant2 = generateImageJSONRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GenerateImageJSONRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GenerateImageJSONRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGenerateImageJSONRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.GenerateImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.GenerateImageJSONRequestVariant2, TResult>? generateImageJSONRequestVariant2 = null,
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
            else if (IsGenerateImageJSONRequestVariant2 && generateImageJSONRequestVariant2 != null)
            {
                return generateImageJSONRequestVariant2(GenerateImageJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.GenerateImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.GenerateImageJSONRequestVariant2>? generateImageJSONRequestVariant2 = null,
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
            else if (IsGenerateImageJSONRequestVariant2)
            {
                generateImageJSONRequestVariant2?.Invoke(GenerateImageJSONRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.GenerateImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.GenerateImageJSONRequestVariant2>? generateImageJSONRequestVariant2 = null,
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
            else if (IsGenerateImageJSONRequestVariant2)
            {
                generateImageJSONRequestVariant2?.Invoke(GenerateImageJSONRequestVariant2!);
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
                GenerateImageJSONRequestVariant2,
                typeof(global::Recraft.GenerateImageJSONRequestVariant2),
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
        public bool Equals(GenerateImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.GenerateImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.GenerateImageJSONRequestVariant2?>.Default.Equals(GenerateImageJSONRequestVariant2, other.GenerateImageJSONRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GenerateImageJSONRequest obj1, GenerateImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GenerateImageJSONRequest obj1, GenerateImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateImageJSONRequest o && Equals(o);
        }
    }
}
